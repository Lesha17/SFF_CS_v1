using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Same_Files_Finder_CS_v1
{
    public partial class Select_mask_form : Form
    {
        public string Selected_mask;
        public Select_mask_form(string mask)
        {
            InitializeComponent();
            masks_tb.Text = mask;
        }

        private void addMasks(Button b)
        {
            char[] sep = new char[1];
            sep[0] = ' ';
            foreach (string s in ((string)b.Tag).Split(sep))
            {
                if (!masks_tb.Text.Contains(s))
                    masks_tb.Text += s + " ";
            }
        }

        private void images_btn_Click(object sender, EventArgs e)
        {
            addMasks(images_btn);
        }

        private void videos_btn_Click(object sender, EventArgs e)
        {
            addMasks(videos_btn);
        }

        private void music_btn_Click(object sender, EventArgs e)
        {
            addMasks(music_btn);
        }

        private void documents_btn_Click(object sender, EventArgs e)
        {
            Selected_mask = masks_tb.Text;
            addMasks(documents_btn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selected_mask = masks_tb.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
