using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company_db
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void addCustomerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void seachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search f = new search();
            f.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporting f = new reporting();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
