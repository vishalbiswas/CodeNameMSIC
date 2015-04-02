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
			this.seek = new System.Windows.Forms.TrackBar();
			this.ppbut = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.file = new System.Windows.Forms.OpenFileDialog();
			this.volumeT = new System.Windows.Forms.Label();
			this.album = new System.Windows.Forms.PictureBox();
			this.playlist = new System.Windows.Forms.ListView();
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nbut = new System.Windows.Forms.Button();
			this.pbut = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.seek)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.album)).BeginInit();
			this.SuspendLayout();
			// 
			// seek
			// 
			this.seek.Location = new System.Drawing.Point(176, 240);
			this.seek.Maximum = 100;
			this.seek.Name = "seek";
			this.seek.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.seek.Size = new System.Drawing.Size(45, 81);
			this.seek.TabIndex = 0;
			this.seek.TickStyle = System.Windows.Forms.TickStyle.None;
			this.seek.ValueChanged += new System.EventHandler(this.seekTo);
			// 
			// ppbut
			// 
			this.ppbut.Enabled = false;
			this.ppbut.Image = global::CodeNameMSIC.Properties.Resources._1428006213_208018;
			this.ppbut.Location = new System.Drawing.Point(67, 225);
			this.ppbut.Name = "ppbut";
			this.ppbut.Size = new System.Drawing.Size(40, 40);
			this.ppbut.TabIndex = 2;
			this.ppbut.UseVisualStyleBackColor = true;
			this.ppbut.Click += new System.EventHandler(this.play);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Image = global::CodeNameMSIC.Properties.Resources._1428006226_208014;
			this.button3.Location = new System.Drawing.Point(67, 271);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 3;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.stop);
			// 
			// button1
			// 
			this.button1.Image = global::CodeNameMSIC.Properties.Resources._1428006297_208033;
			this.button1.Location = new System.Drawing.Point(67, 179);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.open);
			// 
			// file
			// 
			this.file.Filter = "MP3 files|*.mp3";
			this.file.Multiselect = true;
			this.file.Title = "Select MP3 File";
			// 
			// volumeT
			// 
			this.volumeT.Location = new System.Drawing.Point(257, 273);
			this.volumeT.Name = "volumeT";
			this.volumeT.Size = new System.Drawing.Size(36, 23);
			this.volumeT.TabIndex = 5;
			this.volumeT.Text = "100%";
			// 
			// album
			// 
			this.album.Location = new System.Drawing.Point(13, 13);
			this.album.Name = "album";
			this.album.Size = new System.Drawing.Size(154, 135);
			this.album.TabIndex = 6;
			this.album.TabStop = false;
			// 
			// playlist
			// 
			this.playlist.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.playlist.AllowDrop = true;
			this.playlist.AutoArrange = false;
			this.playlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title});
			this.playlist.Location = new System.Drawing.Point(193, 13);
			this.playlist.MultiSelect = false;
			this.playlist.Name = "playlist";
			this.playlist.Size = new System.Drawing.Size(200, 222);
			this.playlist.TabIndex = 8;
			this.playlist.UseCompatibleStateImageBehavior = false;
			this.playlist.View = System.Windows.Forms.View.List;
			// 
			// Title
			// 
			this.Title.Width = 219;
			// 
			// nbut
			// 
			this.nbut.Enabled = false;
			this.nbut.Image = global::CodeNameMSIC.Properties.Resources._1428006282_208015;
			this.nbut.Location = new System.Drawing.Point(113, 225);
			this.nbut.Name = "nbut";
			this.nbut.Size = new System.Drawing.Size(40, 40);
			this.nbut.TabIndex = 2;
			this.nbut.UseVisualStyleBackColor = true;
			this.nbut.Click += new System.EventHandler(this.next);
			// 
			// pbut
			// 
			this.pbut.Enabled = false;
			this.pbut.Image = global::CodeNameMSIC.Properties.Resources._1428006291_208016;
			this.pbut.Location = new System.Drawing.Point(22, 225);
			this.pbut.Name = "pbut";
			this.pbut.Size = new System.Drawing.Size(40, 40);
			this.pbut.TabIndex = 2;
			this.pbut.UseVisualStyleBackColor = true;
			this.pbut.Click += new System.EventHandler(this.previous);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 333);
			this.Controls.Add(this.playlist);
			this.Controls.Add(this.album);
			this.Controls.Add(this.volumeT);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pbut);
			this.Controls.Add(this.nbut);
			this.Controls.Add(this.ppbut);
			this.Controls.Add(this.seek);
			this.Name = "Form1";
			this.Text = "MSIC";
			((System.ComponentModel.ISupportInitialize)(this.seek)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.album)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar seek;
        private System.Windows.Forms.Button ppbut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog file;
		private System.Windows.Forms.Label volumeT;
		private System.Windows.Forms.PictureBox album;
		private System.Windows.Forms.ListView playlist;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.Button nbut;
		private System.Windows.Forms.Button pbut;
	}
}
