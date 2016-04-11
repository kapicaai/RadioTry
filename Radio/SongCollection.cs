using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class SongCollection
    {
        public ICollection<Song> Collection { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public SongCollection()
        {
            Collection = new List<Song>();
        }
        public SongCollection(ICollection<Song> collection)
        {
            Collection = collection;
            Name = "General Collection";
            Description = "General collection";
        }

        public SongCollection(string name, string descr, ICollection<Song> collection) : this(collection)
        {
            Name = name;
            Description = Description;
        }

    }
}
