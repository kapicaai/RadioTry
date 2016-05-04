using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MusicCollection
{
    public class MusicLoader : ILoader<SongCollection>
    {
        bool ILoader<SongCollection>.Download(object source, ref SongCollection result)
        {
            XmlSerializer xReader = new XmlSerializer(typeof(SongCollection));
            try
            {
                result = (SongCollection)xReader.Deserialize(new StreamReader((source as string)));
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        bool ILoader<SongCollection>.Upload(object source, SongCollection songCollect)
        {
            
            try
            {
                StreamWriter sWriter = new StreamWriter(source as string);
                
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        private string ConvertSongToString(Song song)
        {
            StringBuilder sBuild = new StringBuilder();
            sBuild.AppendFormat("{0}*{1}*{2}*{3}*{4}", song.Album, song.Artist, song.SongPath, song.Title, song.Year);
            sBuild.Append("{");
            foreach (string s in song.Tags)
            {
                sBuild.Append(s + ",");
            }

            return sBuild.ToString();
        }
    }

    public class MusicParser : IParser<Song>
    {
        Song IParser<Song>.Parse(string str)
        {
            //тут пока что говнокод, надо придумать что-то получше
            string[] splitted = str.Split('*', '{');
            Song result = new Song();
            result.Album = splitted[0];
            result.Artist = splitted[1];
            result.SongPath = splitted[2];
            result.Title = splitted[3];
            result.Year = splitted[4];
            result.Tags = splitted[5].Split(',').ToList();
            return result;
        }
    }
}
