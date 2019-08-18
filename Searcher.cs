using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System;

namespace FileSearcher
{
    enum SearcherState
    {
        InProgress,
        Paused,
        Stopped
    }

    public class Searcher : ISearcher
    {
        private Thread SearchThread;
        private Task waiter;
        private Stopwatch stopwatch = new Stopwatch();
        private ManualResetEvent mre;
        private SearcherState state = SearcherState.Stopped;
        private bool toPause;

        public int FilesFound { get; private set; }
        public string CurrentFile { get; private set; }
        public string ElapsedTime { get { return (stopwatch.Elapsed.ToString("mm\\:ss\\:ff")); } }        

        public event SearchEventHandler Found;    

        public void StartSearch(string path, string searchPattern, string insideText)
        {
            Regex regex;
            Reset();
            mre = new ManualResetEvent(false);

            if (System.String.IsNullOrWhiteSpace(searchPattern) == false)
            {
                regex = MaskToRegex(searchPattern);
            }
            else
                regex = new Regex(".*");

            state = SearcherState.InProgress;

            stopwatch.Start();

            SearchThread = new Thread(new ParameterizedThreadStart(Search));
            SearchThread.Start(new SearchParameters(path, regex, insideText));

            waiter = Task.Run(() =>
            {
                SearchThread.Join();
                stopwatch.Stop();
            });
        }

        public void Pause()
        {
            if (state == SearcherState.InProgress)
            {
                toPause = true;
                state = SearcherState.Paused;
            }
        }

        public void Continue()
        {
            if (state == SearcherState.Paused)
            {
                mre.Set();
                stopwatch.Start();
                state = SearcherState.InProgress;
            }
        }

        public void Stop()
        {
            if (state != SearcherState.Stopped)
            {
                SearchThread.Abort();
                stopwatch.Stop();
                state = SearcherState.Stopped;
            }
        }

        private void Search(object parameters)
        {
            try
            {
                SearchParameters Parameters = (SearchParameters)parameters;

                string[] dirs = System.IO.Directory.GetDirectories(Parameters.Path);
                foreach (string dir in dirs)
                    Search(new SearchParameters(dir, Parameters.SearchPattern, Parameters.InsideText));

                string[] files = System.IO.Directory.GetFiles(Parameters.Path);
                foreach (string file in files)
                {
                    CurrentFile = file;

                    if (Parameters.SearchPattern.IsMatch(Path.GetFileName(file)) && CompareByInsideText(file, Parameters.InsideText))
                    {
                        Found?.Invoke(file);
                        FilesFound++;
                    }

                    if (toPause == true)
                    {
                        stopwatch.Stop();
                        toPause = false;
                        mre.Reset();
                        mre.WaitOne();                        
                    }
                }
            }
            catch (UnauthorizedAccessException) { }
            catch (ArgumentOutOfRangeException) { }
        }

        private Regex MaskToRegex(string mask)
        {
            return new Regex("^" + mask.Replace(".", "[.]").Replace("*", ".*").Replace("?", ".").Replace("$", @"\$").Replace("^", @"\^") + "$");
        }

        private bool CompareByInsideText(string file, string insideText)
        {
            try
            {
                return File.ReadAllText(file).Contains(insideText);
            }
            catch (OutOfMemoryException)
            {
                return false;
            }
            catch (System.IO.IOException)
            {
                return false;
            }
        }

        private void Reset()
        {
            Stop();
            stopwatch.Reset();
            FilesFound = 0;
            waiter?.Wait();
        }
    }
}