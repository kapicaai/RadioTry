using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{

    interface ILoader<T>
    {
        bool Upload(object resourse, T collectionToUpload);
        bool Download(object resource, ref T collectionToUpload);
    }
}
