﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    [Serializable]
    class SongData
    {
        public string Artist { get; set; } = "Unknown";
        public string Title { get; set; } = "Unknown";
        public string Album { get; set; } = "Unknown";
        public string Year { get; set; }
        public List<string> Tags { get; set; }
        public string SongPath { get; set; }

        private int rating;
        TimeSpan duration;

        public SongData()
        {
            Tags = new List<string>();
            rating = 0;
        }
        public Song CreateSong()
        {
            return new Song(Artist, Title, Album, Year, Tags, SongPath, rating, duration);
        }
    }
}