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
using ExpressMapper;

namespace Radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            BusinessDataMapper mapper = new BusinessDataMapper();
            InitializeComponent();
            ILoader<SongCollectionData> loader = new MusicXmlLoader();
            SongCollectionData collection = new SongCollectionData();
            
            loader.Download("collection.xml", ref collection);
            
            SongCollection sColl;
            sColl = Mapper.Map<SongCollectionData, SongCollection>(collection);
            
            FillPlayListBox(playListBox, sColl.Collection);
            FillGridView(dataGridView1, sColl.Collection);
        }
                

        private void FillPlayListBox(ListBox listBox, IEnumerable<Song> songs)
        {
            foreach(Song s in songs)
            {
                listBox.Items.Add(String.Format("{0} - {1}", s.Artist, s.Title));
            }
        }
        private void FillGridView(DataGridView table, IEnumerable<Song> songs)
        {
            table.DataSource = songs;
            table.Refresh();
        }
    }
}
