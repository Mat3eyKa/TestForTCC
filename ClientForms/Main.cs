using ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms
{
    public partial class Main : Form
    {
        ServiceChatClient chatClient;
        public Main()
        {
            InitializeComponent();
            chatClient = new ServiceChatClient(new ServiceChatClient.EndpointConfiguration());
            LoadData();
        }

        public async void LoadData()
        {
            dgvMain.DataSource = await chatClient.GetPersonsAsync();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private async void Serch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
