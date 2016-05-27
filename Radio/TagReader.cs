using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using System.IO;

namespace MusicCollection
{
    public class TagReader
    {
        SongData song;
        private string SomeTag(string source)
        {
            if (source != null)
                return source;
            return "Unknown";
        }
        public SongData GetSong(string path)
        {
            song = new SongData();

            var audioFile = TagLib.File.Create(path);
            song.Album = SomeTag(audioFile.Tag.Album);
            song.Artist = SomeTag(audioFile.Tag.FirstPerformer);
            song.Duration = new TimeSpan(audioFile.Properties.Duration.Hours, audioFile.Properties.Duration.Minutes,
                audioFile.Properties.Duration.Seconds);
            song.SongPath = path;
            song.Title = SomeTag(audioFile.Tag.Title);
            song.Year = audioFile.Tag.Year.ToString();
            song.number = audioFile.GetHashCode();
            if(audioFile.Tag.Genres != null && audioFile.Tag.Genres.Count() > 0)
                song.Tags.Add(SomeTag(audioFile.Tag.Genres[0]));
            return song;
        }
        public SongCollectionData GetCollectionData(string directory)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);
            SongCollectionData result = new SongCollectionData();
            FileInfo[] files = dir.GetFiles();
            foreach(FileInfo f in files)
            {
                result.Collection.Add(GetSong(f.FullName));
            }

            return result;
        }
    }
}
