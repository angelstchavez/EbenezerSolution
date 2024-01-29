namespace EbenezerSolution.Presentation.Main.Ministries
{
    partial class MinistryForm
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddMinistry = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelBase = new System.Windows.Forms.Panel();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelMinistry = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSide.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSide.Controls.Add(this.flowLayoutPanelMinistry);
            this.panelSide.Controls.Add(this.panelBottom);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(150, 531);
            this.panelSide.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.LightGray;
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.buttonAddMinistry);
            this.panelBottom.Controls.Add(this.textBox1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottom.Location = new System.Drawing.Point(0, 0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(150, 95);
            this.panelBottom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // buttonAddMinistry
            // 
            this.buttonAddMinistry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMinistry.Location = new System.Drawing.Point(8, 10);
            this.buttonAddMinistry.Name = "buttonAddMinistry";
            this.buttonAddMinistry.Size = new System.Drawing.Size(135, 25);
            this.buttonAddMinistry.TabIndex = 1;
            this.buttonAddMinistry.Text = "Agregar";
            this.buttonAddMinistry.UseVisualStyleBackColor = true;
            this.buttonAddMinistry.Click += new System.EventHandler(this.buttonAddMinistry_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 24);
            this.textBox1.TabIndex = 0;
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.SystemColors.Control;
            this.panelBase.Controls.Add(this.buttonDetail);
            this.panelBase.Controls.Add(this.dataGridView);
            this.panelBase.Controls.Add(this.button7);
            this.panelBase.Controls.Add(this.button6);
            this.panelBase.Controls.Add(this.textBoxSearch);
            this.panelBase.Controls.Add(this.button3);
            this.panelBase.Controls.Add(this.buttonAddMember);
            this.panelBase.Controls.Add(this.button1);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(150, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(484, 531);
            this.panelBase.TabIndex = 1;
            // 
            // buttonDetail
            // 
            this.buttonDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDetail.Location = new System.Drawing.Point(12, 449);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(70, 70);
            this.buttonDetail.TabIndex = 12;
            this.buttonDetail.Text = "Detalles";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Numero,
            this.Nombre});
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(460, 402);
            this.dataGridView.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Numero
            // 
            this.Numero.FillWeight = 15.38515F;
            this.Numero.HeaderText = "N°";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 186.6732F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(407, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 25);
            this.button7.TabIndex = 10;
            this.button7.Text = "Limpiar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(339, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(189, 10);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(146, 24);
            this.textBoxSearch.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(402, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reporte";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMember.Location = new System.Drawing.Point(250, 449);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(70, 70);
            this.buttonAddMember.TabIndex = 1;
            this.buttonAddMember.Text = "Agregar";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(326, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMinistry
            // 
            this.flowLayoutPanelMinistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMinistry.Location = new System.Drawing.Point(0, 95);
            this.flowLayoutPanelMinistry.Name = "flowLayoutPanelMinistry";
            this.flowLayoutPanelMinistry.Size = new System.Drawing.Size(150, 436);
            this.flowLayoutPanelMinistry.TabIndex = 1;
            // 
            // MinistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(634, 531);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MinistryForm";
            this.Text = "MinistryForm";
            this.panelSide.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddMinistry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMinistry;
    }
}