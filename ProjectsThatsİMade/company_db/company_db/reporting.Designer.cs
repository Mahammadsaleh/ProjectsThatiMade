
namespace company_db
{
    partial class reporting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporting));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database_CompanyDataSet = new company_db.Database_CompanyDataSet();
            this.CostumersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CostumersTableAdapter = new company_db.Database_CompanyDataSetTableAdapters.CostumersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Database_CompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostumersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.CostumersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "company_db.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(42, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1113, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // Database_CompanyDataSet
            // 
            this.Database_CompanyDataSet.DataSetName = "Database_CompanyDataSet";
            this.Database_CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CostumersBindingSource
            // 
            this.CostumersBindingSource.DataMember = "Costumers";
            this.CostumersBindingSource.DataSource = this.Database_CompanyDataSet;
            // 
            // CostumersTableAdapter
            // 
            this.CostumersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(481, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOAD REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1198, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporting";
            this.Text = "reporting";
            this.Load += new System.EventHandler(this.reporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database_CompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostumersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CostumersBindingSource;
        private Database_CompanyDataSet Database_CompanyDataSet;
        private Database_CompanyDataSetTableAdapters.CostumersTableAdapter CostumersTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}