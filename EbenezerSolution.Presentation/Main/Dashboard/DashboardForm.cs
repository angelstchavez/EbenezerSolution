using System.Collections.Generic;
using System.Windows.Forms;

namespace EbenezerSolution.Presentation.Main.Dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            OpenModule(new Main.Home.HomeForm(), buttonHome);
        }

        #region Functions

        private void OpenModule(Form form, Button button)
        {
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
                buttonHome,
                buttonAttendance,
                buttonEvent,
                buttonActivity,
                buttonMinistry,
                buttonPerson,
                buttonReport,
                buttonConfig
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

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonPerson_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Main.Persons.PersonForm(), buttonPerson);
        }

        private void buttonMinistry_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Main.Ministries.MinistryForm(), buttonMinistry);
        }

        private void buttonAttendance_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Main.Assists.AssistForm(), buttonAttendance);
        }

        private void buttonHome_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Main.Home.HomeForm(), buttonHome);
        }

        private void buttonEvent_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Main.Events.EventForm(), buttonEvent);
        }

        private void buttonActivity_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Main.Activities.ActivityForm(), buttonActivity);
        }

        private void buttonReport_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Main.Reports.ReportForm(), buttonReport);
        }

        private void buttonConfig_Click(object sender, System.EventArgs e)
        {
            OpenModule(new Main.Config.ConfigForm(), buttonConfig);
        }

        #endregion
    }
}
