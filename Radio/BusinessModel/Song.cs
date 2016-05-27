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
        public string Genre { get; set; } = "Unknown";
        public Song()
        {
            Tags = new List<string>();
            
            
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
            this.Duration = duration;
        }
        public static bool FindTag(Song song, IEnumerable<String> tags)
        {
            foreach(string str in song.Tags)
            {
                if (tags.Contains(str))
                    return true;
            }
            return false;
        }

        public static bool FindTitle(Song song, string title)
        {
            return song.Title.ToLower().Contains(title.ToLower());
        }

        public static bool FindAlbum(Song song, string album)
        {
            return song.Album.ToLower().Contains(album.ToLower());
        }

        public static bool FindArtist(Song song, string artist)
        {
            return song.Artist.ToLower().Contains(artist.ToLower());
        }
    }

   
}
