using EbenezerSolution.Business.Controller;
using EbenezerSolution.Entity;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Persons
{
    public partial class PersonSelectForm : Form
    {
        public PersonSelectForm()
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
        
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}