using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Megadrive_app
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();

        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=_Subota_bd;Data Source=MEPHI3-MSSQL");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            try{
                connection.Open();
            }
            catch (Exception ex){
                MessageBox.Show("Произошла ошибка: " + ex);
            }

            string app_login = textBoxLogin.Text;
            string app_pass = textBoxPassword.Text;
            int roleid;

            command.CommandText = $"SELECT * FROM [users] WHERE login = '{app_login}' AND password = '{app_pass}'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows){
                if (reader.Read()){
                    roleid = reader.GetInt32(2);
                    //MessageBox.Show(Convert.ToString(roleid));
                    switch (roleid){
                        case 1: MessageBox.Show("Вы успешно авторизованы как Администротор");
                            break;
                        case 2: MessageBox.Show("Вы успешно авторизованы как Менеджер");
                            break;
                        case 3: MessageBox.Show("Вы успешно авторизованы как Пользователь");
                            break;
                    }

                    this.Hide();
                    fmMain cl = new fmMain(roleid);
                    cl.Show();
                }
            }
            else{
                MessageBox.Show("Введены неверные данные!");
            }


        }

        private void buttonGuestMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmMain cl = new fmMain(0);
            cl.Show();
        }
    }
}
