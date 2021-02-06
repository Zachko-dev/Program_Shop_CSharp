using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progrm_Easy_Shopping
{
    public partial class ClientPanelForm : Form
    {
        public ClientPanelForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNewClient_Click(object sender, EventArgs e)
        {
            var newForm = new AddClientForm();
            newForm.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClientPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEXclient_Click(object sender, EventArgs e)
        {
            var newForm = new Form1();
            newForm.ShowDialog();
        }
    }
}
