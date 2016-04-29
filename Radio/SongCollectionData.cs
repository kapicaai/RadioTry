using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressMapper;
using System.Xml.Serialization;

namespace MusicCollection
{
    [Serializable]
    public class SongCollectionData
    {
        [XmlArray("collection")]
        public List<SongData> Collection { get; set; }
        public SongCollectionData()
        {
            Collection = new List<SongData>();
            Mapper.Register<SongCollectionData, SongCollection>()
                .Member(dest => dest.Name, src => "Main Collection")
                .Member(dest => dest.Description, src => "all songs collection");
        }

    }

    [Serializable]
    public class PlaylistData
    {
        public string Name { get; }
        public string Description { get; }
        public List<int> Playlist { get; }

        //public SongCollection CreateCollection(SongCollectionData mainCollection)
        //{
        //    ICollection<Song> songCollection = new List<Song>();
        //    foreach (int i in Playlist)
        //    {
        //        songCollection.Add(mainCollection.Collection[i]);
        //    }
        //    return new SongCollection(Name, Description, songCollection);
        //}
    }
}
