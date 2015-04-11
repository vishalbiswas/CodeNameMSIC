﻿namespace CodeNameMSIC
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.volumeV = new System.Windows.Forms.TrackBar();
			this.file = new System.Windows.Forms.OpenFileDialog();
			this.volumeT = new System.Windows.Forms.Label();
			this.playlist = new System.Windows.Forms.ListBox();
			this.shuffleT = new MetroFramework.Controls.MetroToggle();
			this.seekT = new MetroFramework.Controls.MetroTrackBar();
			this.seekTime = new System.Windows.Forms.Timer(this.components);
			this.curTime = new MetroFramework.Controls.MetroLabel();
			this.endTime = new MetroFramework.Controls.MetroLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pbut = new System.Windows.Forms.Button();
			this.nbut = new System.Windows.Forms.Button();
			this.ppbut = new System.Windows.Forms.Button();
			this.album = new System.Windows.Forms.PictureBox();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.volumeV)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.album)).BeginInit();
			this.SuspendLayout();
			// 
			// volumeV
			// 
			this.volumeV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.volumeV.Enabled = false;
			this.volumeV.Location = new System.Drawing.Point(166, 431);
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
			this.volumeT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.volumeT.Enabled = false;
			this.volumeT.Location = new System.Drawing.Point(163, 387);
			this.volumeT.Name = "volumeT";
			this.volumeT.Size = new System.Drawing.Size(36, 23);
			this.volumeT.TabIndex = 5;
			this.volumeT.Text = "100%";
			// 
			// playlist
			// 
			this.playlist.AllowDrop = true;
			this.playlist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.playlist.FormattingEnabled = true;
			this.playlist.Location = new System.Drawing.Point(0, 0);
			this.playlist.Name = "playlist";
			this.playlist.Size = new System.Drawing.Size(322, 540);
			this.playlist.TabIndex = 9;
			this.playlist.DragDrop += new System.Windows.Forms.DragEventHandler(this.open);
			this.playlist.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
			this.playlist.DoubleClick += new System.EventHandler(this.change);
			// 
			// shuffleT
			// 
			this.shuffleT.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.shuffleT.AutoSize = true;
			this.shuffleT.DisplayStatus = false;
			this.shuffleT.Location = new System.Drawing.Point(266, 399);
			this.shuffleT.Name = "shuffleT";
			this.shuffleT.Size = new System.Drawing.Size(50, 17);
			this.shuffleT.TabIndex = 10;
			this.shuffleT.Text = "Off";
			this.shuffleT.UseSelectable = true;
			this.shuffleT.Visible = false;
			this.shuffleT.CheckedChanged += new System.EventHandler(this.shuffleTracks);
			// 
			// seekT
			// 
			this.seekT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.seekT.BackColor = System.Drawing.SystemColors.Control;
			this.seekT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.seekT.Enabled = false;
			this.seekT.Location = new System.Drawing.Point(5, 323);
			this.seekT.Name = "seekT";
			this.seekT.Size = new System.Drawing.Size(314, 23);
			this.seekT.TabIndex = 12;
			this.seekT.Text = "metroTrackBar1";
			this.seekT.UseCustomBackColor = true;
			this.seekT.Value = 0;
			this.seekT.ValueChanged += new System.EventHandler(this.seek);
			this.seekT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toggleSeek);
			this.seekT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toggleSeek);
			// 
			// seekTime
			// 
			this.seekTime.Interval = 1000;
			this.seekTime.Tick += new System.EventHandler(this.updateSeek);
			// 
			// curTime
			// 
			this.curTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.curTime.AutoSize = true;
			this.curTime.Location = new System.Drawing.Point(12, 362);
			this.curTime.Name = "curTime";
			this.curTime.Size = new System.Drawing.Size(26, 19);
			this.curTime.TabIndex = 13;
			this.curTime.Text = "0:0";
			this.curTime.UseCustomBackColor = true;
			// 
			// endTime
			// 
			this.endTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.endTime.AutoSize = true;
			this.endTime.Location = new System.Drawing.Point(293, 349);
			this.endTime.Name = "endTime";
			this.endTime.Size = new System.Drawing.Size(26, 19);
			this.endTime.TabIndex = 8;
			this.endTime.Text = "0:0";
			this.endTime.UseCustomBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.volumeT);
			this.splitContainer1.Panel1.Controls.Add(this.endTime);
			this.splitContainer1.Panel1.Controls.Add(this.seekT);
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.playlist);
			this.splitContainer1.Size = new System.Drawing.Size(652, 542);
			this.splitContainer1.SplitterDistance = 324;
			this.splitContainer1.TabIndex = 14;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.album);
			this.splitContainer2.Size = new System.Drawing.Size(322, 540);
			this.splitContainer2.SplitterDistance = 268;
			this.splitContainer2.TabIndex = 13;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(652, 24);
			this.menuStrip1.TabIndex = 15;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.contentsToolStripMenuItem.Text = "&Contents";
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.indexToolStripMenuItem.Text = "&Index";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.searchToolStripMenuItem.Text = "&Search";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pictureBox1.Image = global::CodeNameMSIC.Properties.Resources._1428006239_208025;
			this.pictureBox1.Location = new System.Drawing.Point(228, 391);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Image = global::CodeNameMSIC.Properties.Resources._1428006297_208033;
			this.button1.Location = new System.Drawing.Point(72, 399);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.open);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.Enabled = false;
			this.button3.Image = global::CodeNameMSIC.Properties.Resources._1428006226_208014;
			this.button3.Location = new System.Drawing.Point(72, 491);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 3;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.stop);
			// 
			// pbut
			// 
			this.pbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pbut.Enabled = false;
			this.pbut.Image = global::CodeNameMSIC.Properties.Resources._1428006291_208016;
			this.pbut.Location = new System.Drawing.Point(27, 445);
			this.pbut.Name = "pbut";
			this.pbut.Size = new System.Drawing.Size(40, 40);
			this.pbut.TabIndex = 2;
			this.pbut.UseVisualStyleBackColor = true;
			this.pbut.Click += new System.EventHandler(this.previous);
			// 
			// nbut
			// 
			this.nbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.nbut.Enabled = false;
			this.nbut.Image = global::CodeNameMSIC.Properties.Resources._1428006282_208015;
			this.nbut.Location = new System.Drawing.Point(118, 445);
			this.nbut.Name = "nbut";
			this.nbut.Size = new System.Drawing.Size(40, 40);
			this.nbut.TabIndex = 2;
			this.nbut.UseVisualStyleBackColor = true;
			this.nbut.Click += new System.EventHandler(this.next);
			// 
			// ppbut
			// 
			this.ppbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ppbut.Enabled = false;
			this.ppbut.Image = global::CodeNameMSIC.Properties.Resources._1428006213_208018;
			this.ppbut.Location = new System.Drawing.Point(72, 445);
			this.ppbut.Name = "ppbut";
			this.ppbut.Size = new System.Drawing.Size(40, 40);
			this.ppbut.TabIndex = 2;
			this.ppbut.UseVisualStyleBackColor = true;
			this.ppbut.Click += new System.EventHandler(this.play);
			// 
			// album
			// 
			this.album.Dock = System.Windows.Forms.DockStyle.Fill;
			this.album.Location = new System.Drawing.Point(0, 0);
			this.album.Name = "album";
			this.album.Size = new System.Drawing.Size(322, 268);
			this.album.TabIndex = 6;
			this.album.TabStop = false;
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.open);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 566);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.volumeV);
			this.Controls.Add(this.curTime);
			this.Controls.Add(this.shuffleT);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pbut);
			this.Controls.Add(this.nbut);
			this.Controls.Add(this.ppbut);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Music Player";
			((System.ComponentModel.ISupportInitialize)(this.volumeV)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private MetroFramework.Controls.MetroToggle shuffleT;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroTrackBar seekT;
		private System.Windows.Forms.Timer seekTime;
		private MetroFramework.Controls.MetroLabel curTime;
		private MetroFramework.Controls.MetroLabel endTime;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

