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
        private class SortByArtistHelper : IComparer<Song>
        {
            public int Compare(Song a, Song b)
            {
                Song s1 = (Song)a;
                Song s2 = (Song)b;
                return s1.Artist.ToLower().CompareTo(s2.Artist.ToLower());
            }
        }

        private class SortByTitleHelper : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {
                return (x as Song).Title.ToLower().CompareTo((y as Song).Title.ToLower());
            }
        }

        private class SortByAlbumHelper : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {
                return (x as Song).Album.ToLower().CompareTo((y as Song).Album.ToLower());
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
                return (x as Song).Rating.CompareTo((y as Song).Rating);
            }
        }

        private class SortByDurationHelper : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {
                return (x as Song).Duration.CompareTo((y as Song).Duration);
            }
        }

        public static IComparer<Song> ArtistSort = (IComparer<Song>)new SortByArtistHelper();
        public static IComparer<Song> TitleSort = (IComparer<Song>)new SortByTitleHelper();
        public static IComparer<Song> AlbumSort = (IComparer<Song>)new SortByAlbumHelper();
        public static IComparer<Song> YearSort = (IComparer<Song>)new SortByYearHelper();
        public static IComparer<Song> RatingSort = (IComparer<Song>)new SortByRatingHelper();
        public static IComparer<Song> DurationSort = (IComparer<Song>)new SortByDurationHelper();
    }
}
