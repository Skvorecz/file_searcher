namespace FileSearcher
{
    public delegate void SearchEventHandler(string file);

    interface ISearcher
    {
        event SearchEventHandler Found;
        
        string ElapsedTime { get; }
        string CurrentFile { get; }
        int FilesFound { get; }

        void StartSearch(string path, string searchPattern, string insideText);
        void Pause();
        void Continue();
        void Stop();
    }
}