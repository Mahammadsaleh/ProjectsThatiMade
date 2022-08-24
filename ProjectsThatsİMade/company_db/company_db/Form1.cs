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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_CompanyDataSet.Costumers' table. You can move, or remove it, as needed.
            this.costumersTableAdapter.Fill(this.database_CompanyDataSet.Costumers);

        }

        private void costumersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.costumersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_CompanyDataSet);

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
                genderCheckBox.Text = "Male";
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
                genderCheckBox.Text = "Female";
            else
                genderCheckBox.Text = "??";
        }

        private void fullnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
