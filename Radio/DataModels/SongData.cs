using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MusicCollection
{
    [Serializable]
    public class SongData
    {
        public string Artist { get; set; } = "Unknown";
        public string Title { get; set; } = "Unknown";
        public string Album { get; set; } = "Unknown";
        public string Year { get; set; } = "Unknown";
        public int number;
        [XmlArray]
        public List<string> Tags { get; set; }
        public string SongPath { get; set; }
        public string Genre { get; set; } = "Unknown";
        public TimeSpan Duration { get; set; }
        public int rating { get; set; }

        public SongData()
        {
            Tags = new List<string>();
            rating = 0;
        }
        public SongData(string artist, string title, int number) : this()
        {
            Artist = artist;
            Title = title;
        }
        public override int GetHashCode()
        {
            return (Artist+Title+Album+Year).GetHashCode();
        }
    }
}
