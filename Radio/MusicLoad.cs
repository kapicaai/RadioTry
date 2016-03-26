using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    interface MusicLoad
    {
        bool Upload(string resource, MusicCollection.SongCollection collectionToUpload);
        bool Download(string resource, ref MusicCollection.SongCollection collectionToUpload);
    }
}
