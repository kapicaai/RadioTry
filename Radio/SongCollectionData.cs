using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    class SongCollectionData
    {
        public IDictionary<int, Song> Collection { get; }
        public SongCollection CreateCollection()
        {
            return new SongCollection(Collection.Values);
        }
    }

    class PlaylistData
    {
        public string Name { get; }
        public string Description { get; }
        public List<int> Playlist { get; }

        public SongCollection CreateCollection(SongCollectionData mainCollection)
        {
            ICollection<Song> songCollection = new List<Song>();
            foreach (int i in Playlist)
            {
                songCollection.Add(mainCollection.Collection[i]);
            }
            return new SongCollection(Name, Description, songCollection);
        }
    }
}
