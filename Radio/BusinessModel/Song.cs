using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Radio;

//ninject
namespace MusicCollection
{
    public partial class Song 
    {
        public string Artist { get; set; } = "Unknown";
        public string Title { get; set; } = "Unknown";
        public string Album { get; set; } = "Unknown";
        public string Year { get; set; } = "Unknown";
        public List<string> Tags { get; set; }
        public string SongPath { get; set; }

        public TimeSpan Duration { get; set; }
        public int Rating { get; }

        public Song()
        {
            Tags = new List<string>();
            Rating = 0;
        }
        public Song(string artist, string title) : this()
        {
            Artist = artist;
            Title = title;
        }

        public Song(string artist, string title, string album, string year, List<string> tags, 
            string songPath, int rating, TimeSpan duration) : this()
        {
            Artist = artist;
            Album = album;
            Title = title;
            Year = year;
            Tags = tags;
            SongPath = songPath;
            this.Rating = rating;
            this.Duration = duration;
        }
        public static bool FindTag(Song song, List<String> tags)
        {
            foreach(string str in song.Tags)
            {
                if (tags.Contains(str))
                    return true;
            }
            return false;
        }

    }

   
}
