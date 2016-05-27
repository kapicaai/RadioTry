namespace Radio
{
    partial class RadioForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.allPlayListBox = new System.Windows.Forms.ListBox();
            this.songCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.artistListBox = new System.Windows.Forms.ListBox();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.mainCollectionDataGrid = new System.Windows.Forms.DataGridView();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.playlistDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPlaylistDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPlaylistLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.allCollectionSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.songCollectionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCollectionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPlaylistDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // allPlayListBox
            // 
            this.allPlayListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allPlayListBox.DataSource = this.songCollectionBindingSource;
            this.allPlayListBox.DisplayMember = "Name";
            this.allPlayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.allPlayListBox.FormattingEnabled = true;
            this.allPlayListBox.ItemHeight = 17;
            this.allPlayListBox.Location = new System.Drawing.Point(439, 30);
            this.allPlayListBox.Name = "allPlayListBox";
            this.allPlayListBox.Size = new System.Drawing.Size(185, 191);
            this.allPlayListBox.TabIndex = 2;
            this.allPlayListBox.SelectedIndexChanged += new System.EventHandler(this.allPlayListBox_SelectedIndexChanged);
            // 
            // songCollectionBindingSource
            // 
            this.songCollectionBindingSource.DataSource = typeof(MusicCollection.SongCollection);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(580, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Playlists";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.albumListBox);
            this.panel1.Controls.Add(this.artistListBox);
            this.panel1.Controls.Add(this.tagsListBox);
            this.panel1.Controls.Add(this.mainCollectionDataGrid);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.playlistDataGridView);
            this.panel1.Controls.Add(this.allPlayListBox);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 644);
            this.panel1.TabIndex = 5;
            // 
            // albumListBox
            // 
            this.albumListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.ItemHeight = 17;
            this.albumListBox.Location = new System.Drawing.Point(294, 30);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(139, 191);
            this.albumListBox.TabIndex = 11;
            // 
            // artistListBox
            // 
            this.artistListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.artistListBox.FormattingEnabled = true;
            this.artistListBox.ItemHeight = 17;
            this.artistListBox.Location = new System.Drawing.Point(149, 30);
            this.artistListBox.Name = "artistListBox";
            this.artistListBox.Size = new System.Drawing.Size(139, 191);
            this.artistListBox.TabIndex = 10;
            // 
            // tagsListBox
            // 
            this.tagsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.ItemHeight = 17;
            this.tagsListBox.Location = new System.Drawing.Point(4, 30);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(139, 191);
            this.tagsListBox.TabIndex = 9;
            // 
            // mainCollectionDataGrid
            // 
            this.mainCollectionDataGrid.AllowUserToAddRows = false;
            this.mainCollectionDataGrid.AllowUserToDeleteRows = false;
            this.mainCollectionDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainCollectionDataGrid.AutoGenerateColumns = false;
            this.mainCollectionDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainCollectionDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.mainCollectionDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainCollectionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.mainCollectionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.Duration});
            this.mainCollectionDataGrid.DataSource = this.songBindingSource1;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainCollectionDataGrid.DefaultCellStyle = dataGridViewCellStyle24;
            this.mainCollectionDataGrid.GridColor = System.Drawing.Color.White;
            this.mainCollectionDataGrid.Location = new System.Drawing.Point(0, 250);
            this.mainCollectionDataGrid.Name = "mainCollectionDataGrid";
            this.mainCollectionDataGrid.ReadOnly = true;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainCollectionDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainCollectionDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.mainCollectionDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainCollectionDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainCollectionDataGrid.Size = new System.Drawing.Size(433, 394);
            this.mainCollectionDataGrid.TabIndex = 0;
            this.mainCollectionDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.mainCollectionDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainCollectionDataGrid_CellMouseDoubleClick);
            this.mainCollectionDataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.FillWeight = 58.60029F;
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 58.60029F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.FillWeight = 58.60029F;
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.FillWeight = 20.88515F;
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.FillWeight = 54.95325F;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // songBindingSource1
            // 
            this.songBindingSource1.DataSource = typeof(MusicCollection.Song);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.descriptionLabel.Location = new System.Drawing.Point(635, 30);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(163, 198);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description";
            // 
            // playlistDataGridView
            // 
            this.playlistDataGridView.AllowUserToAddRows = false;
            this.playlistDataGridView.AllowUserToDeleteRows = false;
            this.playlistDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistDataGridView.AutoGenerateColumns = false;
            this.playlistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playlistDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.playlistDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.playlistDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playlistDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.playlistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.playlistDataGridView.DataSource = this.songBindingSource1;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playlistDataGridView.DefaultCellStyle = dataGridViewCellStyle28;
            this.playlistDataGridView.GridColor = System.Drawing.Color.White;
            this.playlistDataGridView.Location = new System.Drawing.Point(439, 250);
            this.playlistDataGridView.Name = "playlistDataGridView";
            this.playlistDataGridView.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playlistDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playlistDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.playlistDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playlistDataGridView.Size = new System.Drawing.Size(359, 391);
            this.playlistDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Artist";
            this.dataGridViewTextBoxColumn4.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn6.HeaderText = "Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn8.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // currentPlaylistDataGrid
            // 
            this.currentPlaylistDataGrid.AllowUserToAddRows = false;
            this.currentPlaylistDataGrid.AllowUserToDeleteRows = false;
            this.currentPlaylistDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPlaylistDataGrid.AutoGenerateColumns = false;
            this.currentPlaylistDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.currentPlaylistDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.currentPlaylistDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.currentPlaylistDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currentPlaylistDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.currentPlaylistDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentPlaylistDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.currentPlaylistDataGrid.DataSource = this.songBindingSource1;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentPlaylistDataGrid.DefaultCellStyle = dataGridViewCellStyle32;
            this.currentPlaylistDataGrid.GridColor = System.Drawing.Color.White;
            this.currentPlaylistDataGrid.Location = new System.Drawing.Point(845, 53);
            this.currentPlaylistDataGrid.Name = "currentPlaylistDataGrid";
            this.currentPlaylistDataGrid.ReadOnly = true;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentPlaylistDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.currentPlaylistDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentPlaylistDataGrid.Size = new System.Drawing.Size(390, 242);
            this.currentPlaylistDataGrid.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Artist";
            this.dataGridViewTextBoxColumn1.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn5.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // currentPlaylistLabel
            // 
            this.currentPlaylistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPlaylistLabel.AutoSize = true;
            this.currentPlaylistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.currentPlaylistLabel.Location = new System.Drawing.Point(903, 11);
            this.currentPlaylistLabel.Name = "currentPlaylistLabel";
            this.currentPlaylistLabel.Size = new System.Drawing.Size(208, 17);
            this.currentPlaylistLabel.TabIndex = 7;
            this.currentPlaylistLabel.Text = "Current Playlist(To Play Queue)";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchTextBox.Location = new System.Drawing.Point(6, 9);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(302, 23);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // allCollectionSearchButton
            // 
            this.allCollectionSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allCollectionSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.allCollectionSearchButton.Location = new System.Drawing.Point(314, 9);
            this.allCollectionSearchButton.Name = "allCollectionSearchButton";
            this.allCollectionSearchButton.Size = new System.Drawing.Size(75, 23);
            this.allCollectionSearchButton.TabIndex = 9;
            this.allCollectionSearchButton.Text = "Search";
            this.allCollectionSearchButton.UseVisualStyleBackColor = true;
            this.allCollectionSearchButton.Click += new System.EventHandler(this.allCollectionSearchButton_Click);
            // 
            // RadioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 698);
            this.Controls.Add(this.allCollectionSearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.currentPlaylistLabel);
            this.Controls.Add(this.currentPlaylistDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "RadioForm";
            this.Text = "Radio";
            ((System.ComponentModel.ISupportInitialize)(this.songCollectionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainCollectionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPlaylistDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ListBox allPlayListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView mainCollectionDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource songBindingSource1;
        private System.Windows.Forms.DataGridView currentPlaylistDataGrid;
        private System.Windows.Forms.DataGridView playlistDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource songCollectionBindingSource;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label currentPlaylistLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button allCollectionSearchButton;
        private System.Windows.Forms.ListBox albumListBox;
        private System.Windows.Forms.ListBox artistListBox;
        private System.Windows.Forms.ListBox tagsListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    }
}

