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
        public string Year { get; set; }
        public int number;
        [XmlArray("tags")]
        public List<string> Tags { get; set; }
        public string SongPath { get; set; }

        private int rating;
        [XmlIgnore]
        TimeSpan duration;

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
        public Song CreateSong()
        {
            return new Song(Artist, Title, Album, Year, Tags, SongPath, rating, duration);
        }
    }
}
