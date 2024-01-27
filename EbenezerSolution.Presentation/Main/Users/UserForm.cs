using EbenezerSolution.Business.Controller;
using EbenezerSolution.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Users
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            this.userController = new UserController();
            InitializeComponent();
            LoadUsers();
        }

        #region Fields

        //Controllers
        private readonly UserController userController;

        //Fields
        private int userId;

        #endregion

        #region Functions

        private void LoadUsers()
        {
            IEnumerable<User> users = userController.GetAll();
            int count = userController.Count();

            labelCount.Text = $"Registros: {count}";

            dataGridView.Rows.Clear();

            foreach (var person in users)
            {
                string status = person.UserIsActive ? "Activo" : "Inactivo";
                dataGridView.Rows.Add(new object[] { person.Id, person.Username, person.Role.RoleName, status });
            }
        }


        #endregion

        #region Events

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonReport_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, System.EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                IEnumerable<User> searchResults = userController.Search(searchTerm);

                dataGridView.Rows.Clear();

                if (searchResults != null && searchResults.Any())
                {
                    foreach (var user in searchResults)
                    {
                        dataGridView.Rows.Add(new object[] { user.Id, user.Username, user.Role.RoleName, user.UserIsActive, });
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un término de búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClearSearch_Click(object sender, System.EventArgs e)
        {
            textBoxSearch.Clear();
            LoadUsers();
        }

        #endregion
    }
}
