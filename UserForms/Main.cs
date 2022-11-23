using ServiceReference;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UserForms
{
    public partial class lbMain : Form
    {
        private int CountOfChecked = 3;
        readonly ServiceClient Client;
        public lbMain()
        {
            Client = new ServiceClient(new ServiceClient.EndpointConfiguration());
            InitializeComponent();
            LoadData();
            MaintoolStripDropDownButton.DropDown.Closing += DropDown_Closing;
            AddressToolStripMenuItem.DropDown.Closing += DropDown_Closing;
            dgvMain.AutoGenerateColumns = false;
            
        }
        private async void LoadData()
        {
            try
            {
                dgvMain.DataSource = await Client.GetPersonsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvMain.Columns["clID"].DisplayIndex = 0;
            dgvMain.Columns["clName"].DisplayIndex = 1;
            dgvMain.Columns["clSurname"].DisplayIndex = 2;
            dgvMain.Columns["сlPatronymic"].DisplayIndex = 3;
            dgvMain.Columns["clDateOfBirth"].DisplayIndex = 4;
            dgvMain.Columns["clPhone"].DisplayIndex = 5;
        }
        private void DropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked || e.CloseReason == ToolStripDropDownCloseReason.AppFocusChange)
                e.Cancel = true;
        }
        private void CheckLetters(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void CheckIsDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void ToolStripMenuItemSettings(object sender, EventArgs e)
        {
            var toolStripMenuItem = ((ToolStripMenuItem)sender);
            StringBuilder sb = new();
            foreach (var item in toolStripMenuItem.Name)
            {
                if (char.IsUpper(item) && sb.Length > 1)
                    break;
                sb.Append(item);
            }

            if (Controls[$"tex{sb}"] is TextBox textBox)
            {
                if (!toolStripMenuItem.Checked)
                {
                    toolStripMenuItem.Checked = true;
                    textBox.Visible = true;
                    btSerch.Visible = true;
                    CountOfChecked++;
                    return;
                }

                CheckButtonVisible();
                toolStripMenuItem.Checked = false;
                textBox.Visible = false;
            }
            // костыль?
            if (Controls[$"tex{sb}"] is DateTimePicker dateTimePicker)
            {
                if (!toolStripMenuItem.Checked)
                {
                    toolStripMenuItem.Checked = true;
                    dateTimePicker.Visible = true;
                    btSerch.Visible = true;
                    CountOfChecked++;
                    return;
                }

                CheckButtonVisible();
                toolStripMenuItem.Checked = false;
                dateTimePicker.Visible = false;
            }
        }
        private void CheckButtonVisible()
        {
            CountOfChecked--;
            if (CountOfChecked == 0)
                btSerch.Visible = false;
        }

        private async void Serch_Click(object sender, EventArgs e)
        {
            var data = string.Empty;
            if (texDateofbirth.Visible)
                data = Convert.ToDateTime(texDateofbirth.Text).ToShortDateString();
           
           dgvMain.DataSource = await Client.GeteSerchedPersonsAsync
            (
               name:texName.Text,
               surname:texSurname.Text,
               patronymic:texPatronymic.Text,
               dateOfBirth:data, 
               phone:texPhone.Text,
               city:texCity.Text,
               street:texStreet.Text,
               house:texHouse.Text,
               room:texRoom.Text
            );
            dgvMain.Columns["clID"].DisplayIndex = 0;
            dgvMain.Columns["clName"].DisplayIndex = 1;
            dgvMain.Columns["clSurname"].DisplayIndex = 2;
            dgvMain.Columns["сlPatronymic"].DisplayIndex = 3;
            dgvMain.Columns["clDateOfBirth"].DisplayIndex = 4;
            dgvMain.Columns["clPhone"].DisplayIndex = 5;
            dgvMain.Columns["clAddress"].DisplayIndex = 6;
        }
    }
}
