namespace FileSearcher
{
    public delegate void SearchEventHandler(string file);

    interface ISearcher
    {
        event SearchEventHandler Found;
        
        string ElapsedTime { get; }
        string CurrentFile { get; }
        ulong FilesFound { get; }
        ulong FilesTotal { get; }

        void StartSearch(string path, string searchPattern, string insideText);
        void Pause();
        void Continue();
        void Stop();
    }
}