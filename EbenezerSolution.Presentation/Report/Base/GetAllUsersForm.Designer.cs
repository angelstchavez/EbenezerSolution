namespace EbenezerSolution.Presentation.Report.Base
{
    partial class GetAllUsersForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getAllPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new EbenezerSolution.Presentation.Report.Data.MasterDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getAllPersonsTableAdapter = new EbenezerSolution.Presentation.Report.Data.MasterDataSetTableAdapters.GetAllPersonsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getAllPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getAllPersonsBindingSource
            // 
            this.getAllPersonsBindingSource.DataMember = "GetAllPersons";
            this.getAllPersonsBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "MasterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.getAllPersonsBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "EbenezerSolution.Presentation.Report.Desing.ReportGetAllPersons.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(684, 461);
            this.reportViewer.TabIndex = 0;
            // 
            // getAllPersonsTableAdapter
            // 
            this.getAllPersonsTableAdapter.ClearBeforeFill = true;
            // 
            // GetAllUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "GetAllUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GetAllUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getAllPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Data.MasterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource getAllPersonsBindingSource;
        private Data.MasterDataSetTableAdapters.GetAllPersonsTableAdapter getAllPersonsTableAdapter;
    }
}