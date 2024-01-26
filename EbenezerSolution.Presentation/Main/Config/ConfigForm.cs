using System.Collections.Generic;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Config
{
    public partial class ConfigForm: Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            panelBase.Visible = false;
        }

        #region Functions

        private void OpenModule(Form form, Button button)
        {
            panelBase.Visible = true;
            OpenNewForm(form);
            ToggleMainButtonsState(true, button);
        }

        private void OpenNewForm(Form module)
        {
            panelBase.Controls.Clear();
            module.TopLevel = false;
            module.Dock = DockStyle.Fill;
            panelBase.Controls.Add(module);
            panelBase.Tag = module;
            module.Show();
            panelBase.BringToFront();
        }

        private void ToggleMainButtonsState(bool state, Button button)
        {
            List<Button> buttons = new List<Button> {
                buttonGeneral,
                buttonUsers,
            };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;

                //button.BackColor = Color.FromArgb(50, 50, 50);

                foreach (Button btn in buttons)
                {
                    if (btn != button)
                    {
                        btn.Enabled = state;

                        //btn.BackColor = Color.FromArgb(40, 40, 40);
                    }
                }
            }
        }

        #endregion

        #region Events

        private void buttonGeneral_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Users.UserForm(), buttonUsers);
        }

        #endregion
    }
}
