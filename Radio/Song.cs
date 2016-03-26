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
        public string Artist { get; set; }
        public string Title { get; set; } 
        public string Album { get; set; }
        public string Year { get; set; }
        public List<string> Tags { get; set; }
        public string SongPath { get; set; }

        [XmlAttribute]
        private int rating;
        TimeSpan longness;

        public Song()
        {
            Tags = new List<string>();
            Year = "1990";
            rating = 0;
        }

        public static IComparer SortByArtist()
        {
            return (IComparer)new SortByArtistHelper(); 
        }

        public static IComparer SortByTitle()
        {
            return (IComparer)new SortByTitleHelper();
        }

        public static IComparer SortByYear()
        {
            return (IComparer)new SortByArtistHelper();
        }
        public static IComparer SortByRating()
        {
            return (IComparer)new SortByRatingHelper();
        }
    }

    [Serializable]
    public class SongCollection
    {
        public List<Song> collection;
        public string name;
        public string description;

        public SongCollection()
        {
            collection = new List<Song>();
        }

        public SongCollection(string name) : this()
        {
            this.name = name;
        }
        
        
         
    }

    public class MusicXmlLoad : MusicLoad
    {
        bool MusicLoad.Download(string fileName, ref SongCollection rezult)
        {
            XmlSerializer xReader = new XmlSerializer(typeof(SongCollection));
            try
            {
                rezult = (SongCollection)xReader.Deserialize(new StreamReader(fileName));
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
         
        bool MusicLoad.Upload(string fileName, SongCollection songCollect)
        {
            XmlSerializer xWriter = new XmlSerializer(typeof(SongCollection));
            try
            {
                xWriter.Serialize(new StreamWriter(fileName), songCollect);
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
