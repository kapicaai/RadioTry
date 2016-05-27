using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicCollection;
using ExpressMapper;

namespace Radio
{
    class Radio
    {

        public List<IComparer<Song>> Comparers { get; set; }
        public SongCollection AllSongs { get; }
        public Queue<Song> CurrentPlaylist { get; set; } = new Queue<Song>();
        public List<SongCollection> AllPlaylists { get; set; }
        public IEnumerable<string> AllTags { get; set; }
        public IEnumerable<string> AllArtists { get; set; }
        public IEnumerable<string> AllAlbums { get; set; }
        public List<Song> CurrentSongList { get; set; } = new List<Song>();


        List<bool> isSorted = new List<bool>();
        public Radio()
        {
            AllSongs = new SongCollection();
            AllPlaylists = new List<SongCollection>();
            AllTags = new List<string>();


            FillComparers();

            for (int i = 0; i < Comparers.Count; i++)
                isSorted.Add(false);

            BusinessDataMapper mapper = new BusinessDataMapper();
            
            ILoader<SongCollectionData> loader = new MusicXmlLoader();
            SongCollectionData collection = (new TagReader()).GetCollectionData(@"F:\Media\Music\music");
            AllSongs = Mapper.Map<SongCollectionData, SongCollection>(collection);
            for(int i = 0; i < 5; i++)
            {
                AllPlaylists.Add(CreatePlaylist("playlist"+i, "test description for playlist"+i+": test test test", i));
            }
            CurrentSongList = AllSongs.Collection;
            currentSongListUpdated();
        }

        private void currentSongListUpdated()
        {
            AllAlbums = (from song in CurrentSongList
                         select song.Album).Distinct().ToList();
            AllArtists = (from song in CurrentSongList
                          select song.Artist).Distinct().ToList();
            AllTags = (from song in CurrentSongList
                       select song.Genre).Distinct().ToList();
        }

        private SongCollection CreatePlaylist(string name, string descr, int i)
        {
            SongCollection s = new SongCollection();
            s.Name = name;
            s.Description = descr;
            string genre = AllSongs.Collection[i+5].Genre;
            s.Collection.AddRange(AllSongs.Collection.FindAll(x => x.Genre == genre));
            return s;
        }
        public void SortCollection(int n)
        {

            if (!isSorted[n])
            {
                AllSongs.Collection.Sort(Comparers[n]);
            }
            else
            {
                AllSongs.Collection.Reverse();
            }
            bool buffer = isSorted[n];
            for (int i = 0; i < isSorted.Count; i++)
            {
                isSorted[i] = false;
            }
            isSorted[n] = !buffer;
        }
        private void FillComparers()
        {
            Comparers = new List<IComparer<Song>>();

            Comparers.Add(Song.ArtistSort);
            Comparers.Add(Song.TitleSort);
            Comparers.Add(Song.AlbumSort);
            Comparers.Add(Song.YearSort);
            Comparers.Add(Song.DurationSort);
        }

        private void FillTags(List<string> tags)
        {
            foreach(Song song in AllSongs.Collection)
            {
                foreach(string tag in song.Tags)
                {
                    if (!AllTags.Contains(tag))
                        tags.Add(tag);
                }
            }
            tags.Sort();
        }

        public void Search(string request)
        {
            if (request != null)
            {
                if (request.Count() > 0)
                    CurrentSongList = AllSongs.Collection.FindAll(x => x.Album.ToLower().Contains(request) ||
                    x.Title.ToLower().Contains(request) || x.Year.Contains(request) ||
                    x.Artist.ToLower().Contains(request));
                else
                    CurrentSongList = AllSongs.Collection;
            }
            currentSongListUpdated();
        }

    }
}
