using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megadrive_app
{
    public partial class fmAddUser : Form
    {
        public fmAddUser()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmMain cl = new fmMain(1);
            cl.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По нажатию кнопки будет добавлен пользователь");
        }
    }
}
