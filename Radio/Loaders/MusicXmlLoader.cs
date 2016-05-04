using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MusicCollection
{
    class MusicXmlLoader : ILoader<SongCollectionData>
    {
        bool ILoader<SongCollectionData>.Upload(object resourse, SongCollectionData collectionToUpload)
        {
            try
            {
                StreamWriter writer = new StreamWriter(resourse as string);
                XmlSerializer serializer = new XmlSerializer(typeof(SongCollectionData));
                serializer.Serialize(writer, collectionToUpload);
                writer.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        bool ILoader<SongCollectionData>.Download(object resource, ref SongCollectionData collectionToDownload)
        {
            try
            {
                StreamReader reader = new StreamReader(resource as string);
                XmlSerializer serializer = new XmlSerializer(typeof(SongCollectionData));
                collectionToDownload = (SongCollectionData)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
