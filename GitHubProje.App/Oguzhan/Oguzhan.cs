using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubProje.App.Oguzhan
{
    public partial class Oguzhan : Form
    {
        public Oguzhan()
        {
            InitializeComponent();
        }

        private void Oguzhan_Load(object sender, EventArgs e)
        {

        }

        private void btnOguzhan_Click(object sender, EventArgs e)
        {
            btnOguzhan.Text = "The only person i know named Oguzhan beside  me";
        }
    }
}
