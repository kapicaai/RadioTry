namespace Radio
{
    partial class Form1
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.AllSongsListBox = new System.Windows.Forms.ListBox();
            this.playListBox = new System.Windows.Forms.ListBox();
            this.allPlayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // AllSongsListBox
            // 
            this.AllSongsListBox.FormattingEnabled = true;
            this.AllSongsListBox.Location = new System.Drawing.Point(12, 37);
            this.AllSongsListBox.Name = "AllSongsListBox";
            this.AllSongsListBox.Size = new System.Drawing.Size(229, 303);
            this.AllSongsListBox.TabIndex = 0;
            // 
            // playListBox
            // 
            this.playListBox.FormattingEnabled = true;
            this.playListBox.Location = new System.Drawing.Point(247, 37);
            this.playListBox.Name = "playListBox";
            this.playListBox.Size = new System.Drawing.Size(213, 303);
            this.playListBox.TabIndex = 1;
            // 
            // allPlayListBox
            // 
            this.allPlayListBox.FormattingEnabled = true;
            this.allPlayListBox.Location = new System.Drawing.Point(466, 37);
            this.allPlayListBox.Name = "allPlayListBox";
            this.allPlayListBox.Size = new System.Drawing.Size(216, 303);
            this.allPlayListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 492);
            this.Controls.Add(this.allPlayListBox);
            this.Controls.Add(this.playListBox);
            this.Controls.Add(this.AllSongsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ListBox AllSongsListBox;
        private System.Windows.Forms.ListBox playListBox;
        private System.Windows.Forms.ListBox allPlayListBox;
    }
}

