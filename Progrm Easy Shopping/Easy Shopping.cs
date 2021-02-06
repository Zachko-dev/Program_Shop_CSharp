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
    public partial class Easy_Shopping : Form
    {
        public Easy_Shopping()
        {
            InitializeComponent();
        }



        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Red;
        }

        private void Closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.White;
        }
        Point lastPoint;

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
           
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var newForm = new ClientPanelForm();
            newForm.ShowDialog();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            var newForm = new AdminPanel();
            newForm.ShowDialog();
        }
    }
}
