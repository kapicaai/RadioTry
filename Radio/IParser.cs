using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    interface IParser<T>
    {
        T Parse(string str);
    }
}
