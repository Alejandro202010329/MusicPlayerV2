using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] paths, files;

        
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;

                for (int x = 0; x <files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();
        }

    }
}
