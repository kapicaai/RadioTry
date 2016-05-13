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
        Radio radio = new Radio();
        public Form1()
        {

            InitializeComponent();
            
            FillGridView(mainCollectionDataGrid, radio.allSongs.Collection);
        }

        private void FillPlayListBox(ListBox listBox, IEnumerable<Song> songs)
        {
            foreach (Song s in songs)
            {
                listBox.Items.Add(String.Format("{0} - {1}", s.Artist, s.Title));
            }
        }
        private void FillPlayListBox(ListBox listBox, IEnumerable<SongCollection> songs)
        {
            foreach (SongCollection s in songs)
            {
                listBox.Items.Add(String.Format("{0} - {1}", s.Name, s.Description));
            }
        }
        private void FillGridView(DataGridView table, IEnumerable<Song> songs)
        {
            table.DataSource = songs;
            table.Refresh();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            (sender as DataGridView).Enabled = false;

            radio.SortCollection(e.ColumnIndex);
            (sender as DataGridView).Refresh();

            (sender as DataGridView).Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Song selectedSong = (sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Song;
            
        }
    }
}
