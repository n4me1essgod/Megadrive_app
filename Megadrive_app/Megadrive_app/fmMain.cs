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
    public partial class fmMain : Form
    {
        int roleid;
        public fmMain(int role)
        {
            InitializeComponent();
            roleid = role;

            if (roleid == 2){
                buttonEditGrid.Visible = true;
                buttonHistory.Visible = true;
            }
            if (roleid == 0){
                buttonBooking.Visible = false;
            }
            if (roleid == 1){
                buttonEditGrid.Visible = true;
                buttonHistory.Visible = true;
                buttonAddUser.Visible = true;
            }
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Subota_bdDataSet1.Transport_view_cuted". При необходимости она может быть перемещена или удалена.
            this.transport_view_cutedTableAdapter.Fill(this._Subota_bdDataSet1.Transport_view_cuted);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Subota_bdDataSet.Transport_view". При необходимости она может быть перемещена или удалена.
            this.transport_viewTableAdapter.Fill(this._Subota_bdDataSet.Transport_view);
            //MessageBox.Show(Convert.ToString(roleid));
        }

        private void buttonExtendedInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmExtendedTransportInformation cl = new fmExtendedTransportInformation(roleid);
            cl.Show();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По нажатию кнопки будет открыта форма бронирования");
        }

        private void buttonEditGrid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По нажатию кнопки будет открыта форма редактирования записи");
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По нажатию кнопки будет открыта форма истории аренды");
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmAddUser cl = new fmAddUser();
            cl.Show();
        }
    }
}
