using System;
using System.Xml.Serialization;
using System.IO;

namespace FileSearcher
{
    [Serializable]
    public class Snapshot
    {
        public string Path { get; set; }
        public string Pattern { get; set; }
        public string InsideText { get; set; }

        public Snapshot() { }

        public Snapshot (string path, string pattern, string insideText)
        {
            Path = path;
            Pattern = pattern;
            InsideText = insideText;
        }

        public void Serialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Snapshot));

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }

        public static Snapshot Deserialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Snapshot));
           
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    return (Snapshot)serializer.Deserialize(stream);
                }
                catch (InvalidOperationException)
                {
                    return new Snapshot();
                }
            }
        }
    }
}