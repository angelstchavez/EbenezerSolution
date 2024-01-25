using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Persons
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        #region Fields

        #endregion

        #region Functions

        #endregion

        #region Events

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            PersonControlForm personControlForm = new PersonControlForm();
            personControlForm.StartPosition = FormStartPosition.CenterParent;
            personControlForm.ShowDialog();
        }

        private void buttonDetail_Click(object sender, System.EventArgs e)
        {
            PersonDetailForm personDetailForm = new PersonDetailForm();
            personDetailForm.StartPosition = FormStartPosition.CenterParent;
            personDetailForm.ShowDialog();
        }

        #endregion
    }
}
