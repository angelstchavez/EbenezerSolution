using EbenezerSolution.Business.Controller;
using EbenezerSolution.Entity;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Persons
{
    public partial class PersonDetailForm : Form
    {
        private PersonController personController;
        private int personId;

        public PersonDetailForm(int id)
        {
            this.personId = id;
            this.personController = new PersonController();
            InitializeComponent();
            LoadPerson();
        }

        private void LoadPerson()
        {
            Person person = personController.Get(personId);

            textBoxName.Text = person.FullName;
            textBoxGender.Text = person.Gender;
            textBoxNumberPhone.Text = person.NumberPhone;
            textBoxAddress.Text = person.Address;
            textBoxBirthDate.Text = person.BirthDate.ToShortDateString();
            textBoxAge.Text = personController.CalculateAge(person.BirthDate).ToString();
            labelCreationData.Text = person.CreationDate.ToLongDateString();
        }
    }
}
