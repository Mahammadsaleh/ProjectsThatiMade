using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace company_db
{
    public partial class reporting : Form
    {
        public reporting()
        {
            InitializeComponent();
        }

        private void reporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database_CompanyDataSet.Costumers' table. You can move, or remove it, as needed.
            this.CostumersTableAdapter.Fill(this.Database_CompanyDataSet.Costumers);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\company_db\company_db\Database_Company.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Costumers where Address= 'Baki' and Gender= 1 ", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); 
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.ReportPath = @"C:\Users\User\source\repos\company_db\company_db\Report1.rdlc";

            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.RefreshReport();

            


        }
    }
}
