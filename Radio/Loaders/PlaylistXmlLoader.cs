using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MusicCollection
{
    class PlaylistXmlLoader : ILoader<PlaylistData>
    {
        public bool Download(object resource, ref PlaylistData collectionToUpload)
        {
            PlaylistData result;
            XmlSerializer xReader = new XmlSerializer(typeof(PlaylistData));
            try
            {
                result = (PlaylistData)xReader.Deserialize(new StreamReader((resource as string)));
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool Upload(object resourse, PlaylistData collectionToUpload)
        {
            try
            {
                StreamWriter writer = new StreamWriter(resourse as string);
                XmlSerializer serializer = new XmlSerializer(typeof(PlaylistData));
                serializer.Serialize(writer, collectionToUpload);
                writer.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
