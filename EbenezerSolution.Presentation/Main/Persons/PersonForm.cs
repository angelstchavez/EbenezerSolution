using EbenezerSolution.Business.Controller;
using EbenezerSolution.Entity;
using EbenezerSolution.Presentation.Report.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Persons
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            this.personController = new PersonController();
            InitializeComponent();
            LoadPersons();
        }

        #region Fields

        //Controllers
        private readonly PersonController personController;

        //Fields
        private int pageSize = 15;
        private int currentPage = 1;
        private int totalPageCount;
        private int personId;

        #endregion

        #region Functions

        private void LoadPersons()
        {
            IEnumerable<Person> persons = personController.GetAllpaginated(pageSize, currentPage);
            int count = personController.Count();

            totalPageCount = (int)Math.Ceiling((double)personController.Count() / pageSize);

            btnPreviousPage.Enabled = currentPage > 1;

            btnNextPage.Enabled = currentPage < totalPageCount;

            labelPage.Text = $"Página {currentPage} de {totalPageCount}";

            labelCount.Text = $"Registros: {count}";

            dataGridView.Rows.Clear();

            foreach (var person in persons)
            {
                int age = personController.CalculateAge(person.BirthDate);

                dataGridView.Rows.Add(new object[] { person.Id, person.FullName, person.Gender, age });
            }
        }

        #endregion

        #region Events

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PersonControlForm personControlForm = new PersonControlForm();
            personControlForm.StartPosition = FormStartPosition.CenterParent;
            personControlForm.ShowDialog();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (personId <= 0)
            {
                MessageBox.Show("Por favor, selecciona una persona.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PersonDetailForm personDetailForm = new PersonDetailForm(personId);
                personDetailForm.StartPosition = FormStartPosition.CenterParent;
                personDetailForm.ShowDialog();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (personId > 0)
                {
                    Person personToDelete = personController.Get(personId);

                    DialogResult result = MessageBox.Show($"¿Seguro que deseas eliminar a \"{personToDelete.FullName}\"?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes && personController.Delete(personId))
                    {
                        MessageBox.Show($"Persona eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPersons();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona a una persona antes de eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar la persona.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            GetAllUsersForm getAllUsersForm = new GetAllUsersForm();
            getAllUsersForm.ShowDialog();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPersons();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPageCount)
            {
                currentPage++;
                LoadPersons();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                IEnumerable<Person> searchResults = personController.Search(searchTerm);

                dataGridView.Rows.Clear();

                if (searchResults != null && searchResults.Any())
                {
                    foreach (var person in searchResults)
                    {
                        int age = personController.CalculateAge(person.BirthDate);

                        dataGridView.Rows.Add(new object[] { person.Id, person.FullName, person.Gender, age });
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

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            LoadPersons();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                personId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        #endregion
    }
}
