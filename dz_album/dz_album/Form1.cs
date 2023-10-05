using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_album
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddTab("nature", Properties.Resources.nature);
            AddTab("City", Properties.Resources.city);
            AddTab("animal", Properties.Resources.animal);
        }

        private void AddTab(string tabName, System.Drawing.Image image)
        {
            TabPage tbp = new TabPage(tabName);

            PictureBox picbox = new PictureBox();
            picbox.Image = image;
            picbox.SizeMode = PictureBoxSizeMode.Zoom;
            picbox.Dock = DockStyle.Fill;

            tbp.Controls.Add(picbox);

            tabControl1.TabPages.Add(tbp);
        }
    }
}
