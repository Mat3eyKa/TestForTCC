using ServiceReference;
using System;
using System.Windows.Forms;

namespace AdminForms
{
    public partial class Adding : Form
    {
        readonly ServiceChatClient chatClient;
        public Adding()
        {
            TopMost = true;
            chatClient = new ServiceChatClient(new ServiceChatClient.EndpointConfiguration());
            InitializeComponent();
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

        private async void tbSave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                await chatClient.CreateAsync(
                name: texAddName.Text,
                surname: texAddSurname.Text,
                patronymic: texAddPatronymic.Text,
                dateOfBirth: texAddDateOfBirth.Text,
                phone: texAddPhone.Text,
                city: texAddCity.Text,
                street: texAddStreet.Text,
                house: texAddHouse.Text,
                room: texAddRoom.Text);
            }
        }

        private bool CheckData()
        {
            if (texAddName.Text == "" && texAddSurname.Text == "" && texAddPatronymic.Text == ""
                && texAddPhone.Text == "" && texAddCity.Text == "" && texAddCity.Text == "" &&
                texAddStreet.Text == "" && texAddHouse.Text == "" && texAddRoom.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return false;
            }

            if (!DateTime.TryParse(texAddDateOfBirth.Text, out _))
            {
                MessageBox.Show("Не правельный ввод даты рождения");
                return false;
            }

            return true;
        }
    }
}
