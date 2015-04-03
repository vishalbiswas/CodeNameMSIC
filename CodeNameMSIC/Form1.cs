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
		List<string> files = new List<string>();

        public Form1()
        {
            InitializeComponent();
            seek.Value = (int)(100*waveOutDevice.Volume);
			waveOutDevice.PlaybackStopped += toggle;
        }

        private void open(object sender, EventArgs e)
        {
			DialogResult res = file.ShowDialog();
			if (res==DialogResult.OK)
			{
				try
				{
					if (files.Count > 0)
					{
						foreach (string fileN in file.FileNames)
						{
							for (int i = 0; i < files.Count; ++i)
							{
								if (fileN != files.ToArray()[i] && i == files.Count - 1)
								{
									playlist.Items.Add(TagLib.File.Create(fileN).Tag.Title);
									files.Add(fileN);
								}
								else if (fileN == files.ToArray()[i] || i == files.Count) break;
							}
						}
					}
					else
					{
						foreach (string fileN in file.FileNames)
						{
							if (TagLib.File.Create(fileN).Tag.Title != null) playlist.Items.Add(TagLib.File.Create(fileN).Tag.Title);
							else playlist.Items.Add(fileN.Substring(fileN.LastIndexOf('\\') + 1));
							files.Add(fileN);
						}
					}
					if (waveOutDevice.PlaybackState == PlaybackState.Stopped)
					{
						initAudio();
						ppbut.Enabled = button3.Enabled = pbut.Enabled = nbut.Enabled = seek.Enabled = volumeT.Enabled = true;
					}
				}
				catch (Exception err)
				{
					MessageBox.Show(err.Message, err.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
					files.RemoveAt(current);
					playlist.Items.RemoveAt(current);
					if (current > 0) --current;
				}
			}
        }

		private void initAudio()
		{
			audioFileReader = new AudioFileReader(files.ToArray()[current]);
			TagLib.File f = TagLib.File.Create(files.ToArray()[current]);
			if (f.Tag.Title != null) Text = f.Tag.Title + " - Music Player";
			else Text = files.ToArray()[current].Substring(files.ToArray()[current].LastIndexOf('\\') + 1) + " - Music Player";
			if (f.Tag.Pictures.Length > 0) album.Image = Image.FromStream(new MemoryStream(f.Tag.Pictures[0].Data.Data)).GetThumbnailImage(album.Width, album.Height, null, IntPtr.Zero);
			waveOutDevice.Init(audioFileReader);
		}

		private void next(object sender, EventArgs e)
		{
			if (current == files.ToArray().Length - 1) current = 0;
			else ++current;
			stop(new object(), new EventArgs());
			try
			{
				initAudio();
				play(new object(), new EventArgs());
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, err.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
				files.RemoveAt(current);
				playlist.Items.RemoveAt(current);
				if (current > 0) --current;
			}
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

		private void toggle(object sender, EventArgs e)
		{
			audioFileReader.Position = 0;
			ppbut.Image = Properties.Resources._1428006213_208018;
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
			if (current == 0) current = files.ToArray().Length - 1;
			else --current;
			stop(new object(), new EventArgs());
			try
			{
				initAudio();
				play(new object(), new EventArgs());
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, err.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
				files.RemoveAt(current);
				playlist.Items.RemoveAt(current);
				if (current > 0) --current;
			}
		}

		private void change(object sender, EventArgs e)
		{
			if (playlist.Items.Count > 0)
			{
				current = playlist.SelectedIndex;
				stop(new object(), new EventArgs());
				try
				{
					initAudio();
					play(new object(), new EventArgs());
				}
				catch (Exception err)
				{
					MessageBox.Show(err.Message, err.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
					files.RemoveAt(current);
					playlist.Items.RemoveAt(current);
					if (current > 0) --current;
				}
			}
		}
	}
}
