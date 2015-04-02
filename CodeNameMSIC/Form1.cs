using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using System.IO;
using TagLib;

namespace CodeNameMSIC
{
    public partial class Form1 : Form
    {
        IWavePlayer waveOutDevice = new WaveOut();
        AudioFileReader audioFileReader;
		int current = 0;
		string[] files;

        public Form1()
        {
            InitializeComponent();
            seek.Value = (int)(100*waveOutDevice.Volume);
        }

        private void open(object sender, EventArgs e)
        {
			DialogResult res = file.ShowDialog();
			if (res==DialogResult.OK)
			{
				files = file.FileNames;
				try
				{
					foreach (string fileN in files)
					{
						playlist.Items.Add(new ListViewItem(TagLib.File.Create(fileN).Tag.Title));

					}
					audioFileReader = new AudioFileReader(files[0]);
					TagLib.File f = TagLib.File.Create(files[0]);
					Text = f.Tag.Title;
					album.Image = Image.FromStream(new MemoryStream(f.Tag.Pictures[0].Data.Data)).GetThumbnailImage(album.Width, album.Height, null, IntPtr.Zero);
					waveOutDevice.Init(audioFileReader);
					ppbut.Enabled = button3.Enabled = pbut.Enabled = nbut.Enabled = true;
				}
				catch { }
			}
        }

		private void next(object sender, EventArgs e)
		{
			if (current == file.FileNames.Length-1) current = 0;
			else ++current;
			stop(new object(), new EventArgs());
			try
			{
				audioFileReader = new AudioFileReader(files[current]);
				TagLib.File f = TagLib.File.Create(files[current]);
				Text = f.Tag.Title;
				album.Image = Image.FromStream(new MemoryStream(f.Tag.Pictures[0].Data.Data)).GetThumbnailImage(album.Width, album.Height, null, IntPtr.Zero);
				waveOutDevice.Init(audioFileReader);
				play(new object(), new EventArgs());
			}
			catch { }
		}

        private void play(object sender, EventArgs e)
        {
            if (waveOutDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                waveOutDevice.Pause();
				ppbut.Image = Properties.Resources._1428006213_208018;
            }
            else
            {
                waveOutDevice.Play();
				ppbut.Image = Properties.Resources._1428006230_208019;
			}
        }

        private void stop(object sender, EventArgs e)
        {
            waveOutDevice.Stop();
            audioFileReader.Position = 0;
			ppbut.Image = Properties.Resources._1428006213_208018;
		}

        private void seekTo(object sender, EventArgs e)
        {
            waveOutDevice.Volume = ((float)seek.Value)/100;
			volumeT.Text = (waveOutDevice.Volume*100).ToString()+"%";
        }

		private void previous(object sender, EventArgs e)
		{
			if (current == 0) current = file.FileNames.Length - 1;
			else --current;
			stop(new object(), new EventArgs());
			try
			{
				audioFileReader = new AudioFileReader(files[current]);
				TagLib.File f = TagLib.File.Create(files[current]);
				Text = f.Tag.Title;
				album.Image = Image.FromStream(new MemoryStream(f.Tag.Pictures[0].Data.Data)).GetThumbnailImage(album.Width, album.Height, null, IntPtr.Zero);
				waveOutDevice.Init(audioFileReader);
				play(new object(), new EventArgs());
			}
			catch { }
		}
	}
}
