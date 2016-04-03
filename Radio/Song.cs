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
    [Serializable]
    public partial class Song 
    {
        public string Artist { get; set; } = "Unknown";
        public string Title { get; set; } = "Unknown";
        public string Album { get; set; } = "Unknown";
        public string Year { get; set; }
        public List<string> Tags { get; set; }
        public string SongPath { get; set; }

        [XmlAttribute]
        private int rating;
        TimeSpan longness;

        public Song()
        {
            Tags = new List<string>();
            rating = 0;
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
