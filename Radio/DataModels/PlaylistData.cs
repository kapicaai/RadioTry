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
    public class PlaylistData
    {
        public string Name { get; }
        public string Description { get; }
        public List<int> Playlist { get; }

        public SongCollection GetSongCollection(SongCollectionData mainCollection)
        {
            List<Song> songCollection = new List<Song>();
            foreach (int i in Playlist)
            {
                songCollection.Add
                    (Mapper.Map<SongData, Song>(mainCollection.Collection.Find(x => x.number == i)));
            }
            return new SongCollection(Name, Description, songCollection);
        }
    }
}
