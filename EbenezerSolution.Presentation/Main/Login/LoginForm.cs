using System;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.DashboardForm dashboardForm = new Dashboard.DashboardForm();
            dashboardForm.Show();
        }
    }
}
