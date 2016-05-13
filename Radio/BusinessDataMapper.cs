using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicCollection;
using ExpressMapper;

namespace Radio
{
    class BusinessDataMapper
    {
        public BusinessDataMapper()
        {
            Mapper.Register<Song, SongData>();
            Mapper.Register<SongData, Song>();
            
            Mapper.Register<SongCollectionData, SongCollection>()
                .Member(dest => dest.Name, src => "Main Collection")
                .Member(dest => dest.Description, src => "all songs collection");
            
            
        }
    }
}
