using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicCollection;
using System.Collections;

namespace MusicCollection
{
    public partial class Song
    {
        private class SortByArtistHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Song s1 = (Song)a;
                Song s2 = (Song)b;
                return s1.Artist.CompareTo(s2.Artist);
            }
        }

        private class SortByTitleHelper : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return (x as Song).Title.CompareTo((y as Song).Title);
            }
        }

        private class SortByYearHelper : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return (x as Song).Year.CompareTo((y as Song).Year);
            }
        }

        private class SortByRatingHelper : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return (x as Song).rating.CompareTo((y as Song).rating);
            }
        }
    }
}
