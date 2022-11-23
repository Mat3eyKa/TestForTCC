using ServiceReference;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AdminForms
{
    public partial class AdmMain : Form
    {
        private int CountOfChecked = 3;
        readonly ServiceChatClient chatClient;
        public static bool IsOpenAdding = false;
        public AdmMain()
        {
            chatClient = new ServiceChatClient(new ServiceChatClient.EndpointConfiguration());
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
                dgvMain.DataSource = await chatClient.GetPersonsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.Columns[e.ColumnIndex].Name == "clCommand" && e.RowIndex != -1)
            {
                var task = dgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (task == "Удалить")
                {
                    int ind = dgvMain.Rows.Count - 1;
                    if (MessageBox.Show("Удалить Строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        chatClient.DeteleAsync(Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells["clId"].Value));

                }
                else if (task == "Изменить")
                {
                    int ind = e.RowIndex;
                    chatClient.UpdateAsync
                    (
                        id: dgvMain.Rows[ind].Cells["clId"].Value.ToString(),
                        name: dgvMain.Rows[ind].Cells["clName"].Value.ToString(),
                        surname: dgvMain.Rows[ind].Cells["clSurname"].Value.ToString(),
                        patronymic: dgvMain.Rows[ind].Cells["clPatronymic"].Value.ToString(),
                        dateOfBirth: Convert.ToDateTime(dgvMain.Rows[ind].Cells["clDateOfBirth"].Value).ToShortDateString(),
                        phone: dgvMain.Rows[ind].Cells["clPhone"].Value.ToString(),
                        city: dgvMain.Rows[ind].Cells["clCity"].Value.ToString(),
                        street: dgvMain.Rows[ind].Cells["clStreet"].Value.ToString(),
                        house: dgvMain.Rows[ind].Cells["clHouse"].Value.ToString(),
                        room: dgvMain.Rows[ind].Cells["clRoom"].Value.ToString()
                    );
                }
            }
            LoadData();
        }

        private async void Serch_Click(object sender, EventArgs e)
        {
            var data = string.Empty; 
            if (texDateofbirth.Visible)
                data = Convert.ToDateTime(texDateofbirth.Text).ToShortDateString();

            dgvMain.DataSource = await chatClient.GeteSerchedPersonsAsync
             (
                name: texName.Text,
                surname: texSurname.Text,
                patronymic: texPatronymic.Text,
                dateOfBirth: data,
                phone: texPhone.Text,
                city: texCity.Text,
                street: texStreet.Text,
                house: texHouse.Text,
                room: texRoom.Text
             );
        }

        private void CheckButtonVisible()
        {
            CountOfChecked--;
            if (CountOfChecked == 0)
                btSerch.Visible = false;
        }

        private void dgvMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.Rows.Count>1)
            {
                dgvMain[10, e.RowIndex] = new DataGridViewButtonCell
                {
                    Value = "Изменить"
                };
            }
        }

        private void dgvMain_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dssd = sender;
            if (dgvMain.Rows[e.RowIndex].IsNewRow)
                return;
            dgvMain.Rows[e.RowIndex].ErrorText = "";

            if (e.ColumnIndex == 0 || e.ColumnIndex == 5 || e.ColumnIndex == 8 || e.ColumnIndex == 9)
                if (!int.TryParse(e.FormattedValue.ToString(),
                out int newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgvMain.Rows[e.RowIndex].ErrorText = "Oшибка числовых данных";
                    return;
                }

            if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                if (!Regex.IsMatch(e.FormattedValue.ToString(), "^[А-Яа-я]+$"))
                {
                    e.Cancel = true;
                    dgvMain.Rows[e.RowIndex].ErrorText = "Oшибка буквенных данных";
                    return;
                }

            if (e.ColumnIndex == 4)
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out _) )
                {
                    e.Cancel = true;
                    dgvMain.Rows[e.RowIndex].ErrorText = "Oшибка ввода даты, введите дату в ормате DD.MM.YYYY";
                    return;
                }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 2)
            {
                IsOpenAdding = true;
                Adding adding = new ();
                adding.Show();
                return;
            }
        }

        private void toolStripUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
