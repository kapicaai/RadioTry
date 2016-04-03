using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace MusicCollection
{
    public class MusicXmlLoad : ILoad<SongCollection>
    {
        bool ILoad<SongCollection>.Download(string fileName, ref SongCollection rezult)
        {
            XmlSerializer xReader = new XmlSerializer(typeof(SongCollection));
            try
            {
                rezult = (SongCollection)xReader.Deserialize(new StreamReader(fileName));
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        bool ILoad<SongCollection>.Upload(string fileName, SongCollection songCollect)
        {
            XmlSerializer xWriter = new XmlSerializer(typeof(SongCollection));
            try
            {
                xWriter.Serialize(new StreamWriter(fileName), songCollect);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
