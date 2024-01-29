using EbenezerSolution.Business.Controller;
using EbenezerSolution.Entity;
using EbenezerSolution.Presentation.Main.Persons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Ministries
{
    public partial class MinistryForm : Form
    {
        private readonly MinistryController ministryController;
        private int personId;

        public MinistryForm()
        {
            this.ministryController = new MinistryController();
            InitializeComponent();
            DrawMinistries();
        }

        #region Functions

        private void DrawMinistries()
        {
            try
            {
                flowLayoutPanelMinistry.Controls.Clear();
                IEnumerable<Ministry> categories = ministryController.GetAll().OrderBy(c => c.Name);

                foreach (var category in categories)
                {
                    CreateMinistryElements(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void CreateMinistryElements(Ministry ministry)
        {
            Label label = new Label();
            Panel panelOne = new Panel();
            Panel panelTwo = new Panel();

            label.Text = ministry.Name;
            label.Name = ministry.Id.ToString();
            label.Size = new Size(119, 25);
            label.Font = new Font("Arial", 12);
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.Black;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Cursor = Cursors.Hand;

            panelOne.Size = new Size(140, 80);
            panelOne.BorderStyle = BorderStyle.FixedSingle;
            panelOne.Dock = DockStyle.Bottom;
            panelOne.BackColor = Color.White;
            panelOne.Name = ministry.Id.ToString();

            panelTwo.Size = new Size(140, 25);
            panelTwo.Dock = DockStyle.Top;
            panelTwo.BackColor = Color.Transparent;
            panelTwo.BorderStyle = BorderStyle.None;

            MenuStrip Menustrip = new MenuStrip();
            Menustrip.BackColor = Color.Transparent;
            Menustrip.AutoSize = false;
            Menustrip.Size = new Size(28, 24);
            Menustrip.Dock = DockStyle.Right;
            Menustrip.Name = ministry.Id.ToString();
            ToolStripMenuItem ToolStripMain = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripEdit = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripDelete = new ToolStripMenuItem();
            ToolStripMenuItem ToolStripRestart = new ToolStripMenuItem();

            ToolStripMain.Image = Properties.Resources._16_config;
            ToolStripMain.BackColor = Color.Transparent;

            ToolStripEdit.Text = "Editar";
            //ToolStripEdit.Image = Properties.Resources._16_edit;
            ToolStripEdit.Name = ministry.Name;
            ToolStripEdit.Tag = ministry.Id.ToString();

            ToolStripDelete.Text = "Eliminar";
            //ToolStripDelete.Image = Properties.Resources._16_delete;
            ToolStripDelete.Tag = ministry.Id.ToString();

            ToolStripRestart.Text = "Restaurar";
            //ToolStripRestart.Image = Properties.Resources._16_restart;
            ToolStripRestart.Tag = ministry.Id.ToString();

            Menustrip.Items.Add(ToolStripMain);
            ToolStripMain.DropDownItems.Add(ToolStripEdit);
            ToolStripMain.DropDownItems.Add(ToolStripDelete);
            ToolStripMain.DropDownItems.Add(ToolStripRestart);

            panelTwo.Controls.Add(Menustrip);
            panelOne.Controls.Add(label);
            panelOne.Controls.Add(panelTwo);

            label.BringToFront();
            panelTwo.SendToBack();
            flowLayoutPanelMinistry.Controls.Add(panelOne);

            //label.Click += new EventHandler(myLabelEvent);
        }

        #endregion

        private void buttonAddMinistry_Click(object sender, EventArgs e)
        {
            MinistryControlForm ministryControlForm = new MinistryControlForm();
            ministryControlForm.StartPosition = FormStartPosition.CenterParent;
            ministryControlForm.ShowDialog();
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            PersonSelectForm personSelectForm = new PersonSelectForm();
            personSelectForm.StartPosition = FormStartPosition.CenterParent;
            personSelectForm.ShowDialog();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            PersonDetailForm personDetailForm = new PersonDetailForm(personId);
            personDetailForm.StartPosition = FormStartPosition.CenterParent;
            personDetailForm.ShowDialog();
        }
    }
}
