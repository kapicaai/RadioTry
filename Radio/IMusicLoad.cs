using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    interface ILoad<T>
    {
        bool Upload(string resource, T collectionToUpload);
        bool Download(string resource, ref T collectionToUpload);
    }
}
