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
using System.Reflection;


namespace Radio
{
    public partial class RadioForm : Form
    {
        Radio radio;
        public RadioForm()
        {
            radio = new Radio();
            InitializeComponent();
            
            FillGridView(mainCollectionDataGrid, radio.CurrentSongList);
            mainCollectionDataGrid.VirtualMode = true;

            allPlayListBox.DataSource = radio.AllPlaylists;
            currentPlaylistDataGrid.DataSource = radio.CurrentPlaylist;
            tagsListBox.DataSource = radio.AllTags;
            artistListBox.DataSource = radio.AllArtists;
            albumListBox.DataSource = radio.AllAlbums;

            SetDoubleBuffered(mainCollectionDataGrid);
            SetDoubleBuffered(playlistDataGridView);
            SetDoubleBuffered(currentPlaylistDataGrid);
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

        public static void SetDoubleBuffered(Control control)
        {
            // set instance non-public property with name "DoubleBuffered" to true
            typeof(Control).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, control, new object[] { true });
        }

        private void FillGridView(DataGridView table, IEnumerable<Song> songs)
        {
            table.DataSource = songs;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            (sender as DataGridView).Enabled = false;

            radio.SortCollection(e.ColumnIndex);

            (sender as DataGridView).Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Song selectedSong = (sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Song;
            
        }

        private void allPlayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            descriptionLabel.Text = ((sender as ListBox).SelectedItem as SongCollection).Description;
            playlistDataGridView.DataSource = ((sender as ListBox).SelectedItem as SongCollection).Collection;
            playlistDataGridView.Refresh();
        }

        private void allCollectionSearchButton_Click(object sender, EventArgs e)
        {
            radio.Search(searchTextBox.Text.ToLower());
            
            mainCollectionDataGrid.DataSource = null;
            mainCollectionDataGrid.DataSource = radio.CurrentSongList;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            allCollectionSearchButton_Click(null, null);
            artistListBox.DataSource = null;
            artistListBox.DataSource = radio.AllArtists;
        }

        private void mainCollectionDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            radio.CurrentPlaylist.Enqueue((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Song);
            currentPlaylistDataGrid.DataSource = null;
            currentPlaylistDataGrid.DataSource = radio.CurrentPlaylist;
        }
    }
}
