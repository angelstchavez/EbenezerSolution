using EbenezerSolution.Entity;
using EbenezerSolution.Presentation.Main.Persons;
using System;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Ministries
{
    public partial class MinistryForm : Form
    {
        private int personId;

        public MinistryForm()
        {
            InitializeComponent();
        }

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
