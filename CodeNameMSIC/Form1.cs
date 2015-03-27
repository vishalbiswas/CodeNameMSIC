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

        public Form1()
        {
            InitializeComponent();
            seek.Value = (int)(100*waveOutDevice.Volume);
        }

        private void open(object sender, EventArgs e)
        {
            file.ShowDialog();
            try
            {
				foreach(string fileN in file.FileNames)
				{
					playlist.Items.Add(new ListViewItem(TagLib.File.Create(fileN).Tag.Title));

				}
                audioFileReader = new AudioFileReader(file.FileNames[0]);
				TagLib.File f = TagLib.File.Create(file.FileNames[0]);
				Text = f.Tag.Title;
				album.Image = Image.FromStream(new MemoryStream(f.Tag.Pictures[0].Data.Data)).GetThumbnailImage(album.Width, album.Height, null, IntPtr.Zero);
                waveOutDevice.Init(audioFileReader);
                ppbut.Enabled = button3.Enabled = true;
            }
            catch {	}
        }

        private void play(object sender, EventArgs e)
        {
            if (waveOutDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                waveOutDevice.Pause();
                ppbut.Text = "Play";
            }
            else
            {
                waveOutDevice.Play();
                ppbut.Text = "Pause";
            }
        }

        private void stop(object sender, EventArgs e)
        {
            waveOutDevice.Stop();
            audioFileReader.Position = 0;
            ppbut.Text = "Play";
        }

        private void seekTo(object sender, EventArgs e)
        {
            waveOutDevice.Volume = ((float)seek.Value)/100;
			volumeT.Text = (waveOutDevice.Volume*100).ToString()+"%";
        }
    }
}
