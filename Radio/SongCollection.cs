using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class SongCollection
    {
        public List<Song> Collection { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public SongCollection()
        {
            Collection = new List<Song>();

        }

        public SongCollection(string name, string descr) : this()
        {
            Name = name;
            Description = Description;
        }

    }
}
