using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Report.Base
{
    public partial class GetAllUsersForm : Form
    {
        public GetAllUsersForm()
        {
            InitializeComponent();
        }

        private void GetAllUsersForm_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.GetAllPersons' Puede moverla o quitarla según sea necesario.
            this.getAllPersonsTableAdapter.Fill(this.masterDataSet.GetAllPersons);

            this.reportViewer.RefreshReport();
        }
    }
}
