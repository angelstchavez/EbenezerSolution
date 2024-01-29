using EbenezerSolution.Presentation.Main.Persons;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Assists
{
    public partial class AssistForm : Form
    {
        public AssistForm()
        {
            InitializeComponent();
        }

        private void buttonAddAssist_Click(object sender, System.EventArgs e)
        {
            PersonSelectForm personSelectForm = new PersonSelectForm();
            personSelectForm.StartPosition = FormStartPosition.CenterParent;
            personSelectForm.ShowDialog();
        }
    }
}
