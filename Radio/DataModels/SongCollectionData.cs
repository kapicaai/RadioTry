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

        }

    }
}
