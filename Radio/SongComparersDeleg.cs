using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicCollection;
using System.Collections.Generic;
using System.Collections;

namespace MusicCollection
{
    public partial class Song
    {
        private class SortByArtistHelper : IComparer<Song>
        {
            public int Compare(Song a, Song b)
            {
                Song s1 = (Song)a;
                Song s2 = (Song)b;
                return s1.Artist.CompareTo(s2.Artist);
            }
        }

        private class SortByTitleHelper : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {
                return (x as Song).Title.CompareTo((y as Song).Title);
            }
        }

        private class SortByYearHelper : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {
                return (x as Song).Year.CompareTo((y as Song).Year);
            }
        }

        private class SortByRatingHelper : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {
                return (x as Song).rating.CompareTo((y as Song).rating);
            }
        }

        public static IComparer<Song> ArtistSort = (IComparer<Song>)new SortByArtistHelper();
        public static IComparer<Song> TitleSort = (IComparer<Song>)new SortByArtistHelper();
        public static IComparer<Song> YearSort = (IComparer<Song>)new SortByArtistHelper();
        public static IComparer<Song> RatingSort = (IComparer<Song>)new SortByArtistHelper();
    }
}
