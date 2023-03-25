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
    public partial class fmExtendedTransportInformation : Form
    {
        int roleid;
        public fmExtendedTransportInformation(int role)
        {
            InitializeComponent();
            roleid = role;
        }

        private void fmExtendedTransportInformation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Subota_bdDataSet.Transport_view". При необходимости она может быть перемещена или удалена.
            this.transport_viewTableAdapter.Fill(this._Subota_bdDataSet.Transport_view);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmMain cl = new fmMain(roleid);
            cl.Show();
        }
    }
}
