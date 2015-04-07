namespace CodeNameMSIC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.volumeV = new System.Windows.Forms.TrackBar();
			this.file = new System.Windows.Forms.OpenFileDialog();
			this.volumeT = new System.Windows.Forms.Label();
			this.playlist = new System.Windows.Forms.ListBox();
			this.album = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pbut = new System.Windows.Forms.Button();
			this.nbut = new System.Windows.Forms.Button();
			this.ppbut = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.volumeV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.album)).BeginInit();
			this.SuspendLayout();
			// 
			// volumeV
			// 
			this.volumeV.Enabled = false;
			this.volumeV.Location = new System.Drawing.Point(177, 402);
			this.volumeV.Maximum = 100;
			this.volumeV.Name = "volumeV";
			this.volumeV.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.volumeV.Size = new System.Drawing.Size(45, 81);
			this.volumeV.TabIndex = 0;
			this.volumeV.TickStyle = System.Windows.Forms.TickStyle.None;
			this.volumeV.Value = 100;
			this.volumeV.ValueChanged += new System.EventHandler(this.volume);
			// 
			// file
			// 
			this.file.Filter = "Audio files|*.mp3;*.aac;*.wma;*.wav;*.m4a;";
			this.file.Multiselect = true;
			this.file.Title = "Select Audio File";
			// 
			// volumeT
			// 
			this.volumeT.Enabled = false;
			this.volumeT.Location = new System.Drawing.Point(206, 433);
			this.volumeT.Name = "volumeT";
			this.volumeT.Size = new System.Drawing.Size(36, 23);
			this.volumeT.TabIndex = 5;
			this.volumeT.Text = "100%";
			// 
			// playlist
			// 
			this.playlist.AllowDrop = true;
			this.playlist.FormattingEnabled = true;
			this.playlist.Location = new System.Drawing.Point(335, 12);
			this.playlist.Name = "playlist";
			this.playlist.Size = new System.Drawing.Size(305, 537);
			this.playlist.TabIndex = 9;
			this.playlist.DragDrop += new System.Windows.Forms.DragEventHandler(this.open);
			this.playlist.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
			this.playlist.DoubleClick += new System.EventHandler(this.change);
			// 
			// album
			// 
			this.album.Location = new System.Drawing.Point(13, 13);
			this.album.Name = "album";
			this.album.Size = new System.Drawing.Size(316, 316);
			this.album.TabIndex = 6;
			this.album.TabStop = false;
			// 
			// button1
			// 
			this.button1.Image = global::CodeNameMSIC.Properties.Resources._1428006297_208033;
			this.button1.Location = new System.Drawing.Point(76, 370);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.open);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Image = global::CodeNameMSIC.Properties.Resources._1428006226_208014;
			this.button3.Location = new System.Drawing.Point(76, 462);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 3;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.stop);
			// 
			// pbut
			// 
			this.pbut.Enabled = false;
			this.pbut.Image = global::CodeNameMSIC.Properties.Resources._1428006291_208016;
			this.pbut.Location = new System.Drawing.Point(31, 416);
			this.pbut.Name = "pbut";
			this.pbut.Size = new System.Drawing.Size(40, 40);
			this.pbut.TabIndex = 2;
			this.pbut.UseVisualStyleBackColor = true;
			this.pbut.Click += new System.EventHandler(this.previous);
			// 
			// nbut
			// 
			this.nbut.Enabled = false;
			this.nbut.Image = global::CodeNameMSIC.Properties.Resources._1428006282_208015;
			this.nbut.Location = new System.Drawing.Point(122, 416);
			this.nbut.Name = "nbut";
			this.nbut.Size = new System.Drawing.Size(40, 40);
			this.nbut.TabIndex = 2;
			this.nbut.UseVisualStyleBackColor = true;
			this.nbut.Click += new System.EventHandler(this.next);
			// 
			// ppbut
			// 
			this.ppbut.Enabled = false;
			this.ppbut.Image = global::CodeNameMSIC.Properties.Resources._1428006213_208018;
			this.ppbut.Location = new System.Drawing.Point(76, 416);
			this.ppbut.Name = "ppbut";
			this.ppbut.Size = new System.Drawing.Size(40, 40);
			this.ppbut.TabIndex = 2;
			this.ppbut.UseVisualStyleBackColor = true;
			this.ppbut.Click += new System.EventHandler(this.play);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 566);
			this.Controls.Add(this.playlist);
			this.Controls.Add(this.album);
			this.Controls.Add(this.volumeT);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pbut);
			this.Controls.Add(this.nbut);
			this.Controls.Add(this.ppbut);
			this.Controls.Add(this.volumeV);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(668, 605);
			this.MinimumSize = new System.Drawing.Size(668, 605);
			this.Name = "Form1";
			this.Text = "Music Player";
			((System.ComponentModel.ISupportInitialize)(this.volumeV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.album)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar volumeV;
        private System.Windows.Forms.Button ppbut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog file;
		private System.Windows.Forms.Label volumeT;
		private System.Windows.Forms.PictureBox album;
		private System.Windows.Forms.Button nbut;
		private System.Windows.Forms.Button pbut;
		private System.Windows.Forms.ListBox playlist;
	}
}

