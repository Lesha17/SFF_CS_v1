using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows;

namespace Same_Files_Finder_CS_v1
{
    public partial class Form1 : Form
    {
        private string dir;
        Worker w;
        Dictionary<string, List<string>> d;

        public Form1()
        {
            InitializeComponent();
            dir = "/";
            select_Dir_by_Dialog();
            info_label.Text = "Поиск будет проходить в " + dir;
            w = new Worker(dir);
        }

        void select_Dir_by_Dialog()
        {
            if(select_dir_Dialog.ShowDialog() == DialogResult.OK)
            {
                dir = select_dir_Dialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w.update += w_update;
            w.finished += w_finished;
            w.start();
        }

        void w_finished(Dictionary<string, List<string>> d)
        {
            BeginInvoke(new ThreadStart(delegate
                {
                    this.d = d;
                    update_list_box();
                }));
        }

        void w_update(string current)
        {
            BeginInvoke(new ThreadStart(delegate { info_label.Text = current; }));
        }

        void update_list_box()
        {
            listBox1.BeginUpdate();
            listBox1.Items.Clear();

            foreach(string s in d.Keys)
            {
                listBox1.Items.Add(s);
            }

            listBox1.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected  = (string)listBox1.SelectedItem;
            listBox2.BeginUpdate();
            listBox2.Items.Clear();

            foreach(string s in d[selected])
            {
                listBox2.Items.Add(s);
            }

            listBox2.EndUpdate();
        }
    }
}
