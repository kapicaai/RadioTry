using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicCollection;

namespace Radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ILoader<SongCollectionData> loader = new MusicXmlLoader();
            SongCollectionData collection = BuildCollection();
            loader.Upload("collection.xml", collection);
            FillListBox(AllSongsListBox, collection.Collection);
        }

        private SongCollectionData BuildCollection()
        {
            SongCollectionData sc = new SongCollectionData();
            for (int i = 0; i < 30; i++)
                sc.Collection.Add(new SongData(i.ToString(), (i*10).ToString(), i));
            return sc;
        }

        private void FillListBox(ListBox listBox, IEnumerable<SongData> songs)
        {
            foreach(SongData s in songs)
            {
                listBox.Items.Add(String.Format("{0} - {1}", s.Artist, s.Title));
            }
        }
    }
}
