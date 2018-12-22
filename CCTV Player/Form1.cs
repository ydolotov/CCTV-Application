using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTV_Player
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
        }

        private void axVLCPlugin21_Enter(object sender, EventArgs e)
        {
            axVLCPlugin21.AutoPlay = true;
            axVLCPlugin21.playlist.add("rtsp://admin:23101974@109.160.31.235:704/udp/av0_0"); //Запускаем поток RTSP

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.play();
            pictureBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop();
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

           // axVLCPlugin21.video.takeSnapshot();

            // Process.Start("C://Program Files//Videolan//VLC//VLC.exe", "\"rtsp://xxx.xxx.xxx.xxx:554/h264\");
            //  if (axVLCPlugin21.playlist != null)
            // {
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.Title = "Save";
            //    sfd.OverwritePrompt = true;
            //    sfd.CheckFileExists = true;
            //   sfd.Filter = "Video File(*.mp4)|*.mp4";

            // Vlc.DotNet.Core.VlcMediaPlayer player = new Vlc.DotNet.Core.VlcMediaPlayer(new System.IO.DirectoryInfo("C:\\Program Files (x86)\\VideoLAN\\VLC"));
            // AXVLC.DotNet.Core.VlcMedia media = player.SetMedia(new System.IO.FileInfo(videoFullPath)); 
            // saveFileDialog1.InitialDirectory = @"C:\picture";
            // saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    axVLCPlugin21.Save(saveFileDialog1.FileName);
            // }
            // }
        }

        private void axVLCPlugin22_Enter(object sender, EventArgs e)
        {
            axVLCPlugin22.playlist.add("rtsp://admin:23101974@109.160.31.235:704/udp/av0_0"); //Запускаем поток RTSP
        }

        private void axVLCPlugin23_Enter(object sender, EventArgs e)
        {
            axVLCPlugin23.playlist.add("rtsp://admin:23101974@109.160.31.235:704/udp/av0_0"); //Запускаем поток RTSP
        }

        private void axVLCPlugin24_Enter(object sender, EventArgs e)
        {
            axVLCPlugin24.playlist.add("rtsp://admin:23101974@109.160.31.235:704/udp/av0_0"); //Запускаем поток RTSP
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axVLCPlugin22.playlist.play();
            pictureBox3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axVLCPlugin22.playlist.stop();
            pictureBox3.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axVLCPlugin23.playlist.play();
            pictureBox2.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axVLCPlugin23.playlist.stop();
            pictureBox2.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axVLCPlugin24.playlist.play();
            pictureBox4.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axVLCPlugin24.playlist.stop();
            pictureBox4.Visible = false;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            axVLCPlugin21.video.takeSnapshot(); //MAKE SNAPSHOT
            pictureBox5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axVLCPlugin22.video.takeSnapshot();
            pictureBox6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axVLCPlugin23.video.takeSnapshot();
            pictureBox7.Visible = true;
        }

        int i;
        private void button11_Click(object sender, EventArgs e)
        {
            axVLCPlugin24.video.takeSnapshot();

            if (i == 1)
            {
                pictureBox8.Visible = false;
            }
            else {
                pictureBox8.Visible = true;
            }
  
        }
    }
}
