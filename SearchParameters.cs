using System.Text.RegularExpressions;

namespace FileSearcher
{
    public class SearchParameters
    {
        public string Path { get; }
        public Regex SearchPattern { get; }
        public string InsideText { get; }        

        public SearchParameters (string path, Regex searchPattern, string insideText)
        {
            Path = path;
            SearchPattern = searchPattern;
            InsideText = insideText;
        }
    }
}