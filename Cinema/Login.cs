using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        conn = new SqlConnection(@"server=DESKTOP-A5RCAJ3;initial Catalog=Cinema; integrated security=true");
            txtbox_Pass.PasswordChar = '*';
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtbox_Username.Text != string.Empty || txtbox_Pass.Text != string.Empty)
            {
                conn.Open();
                cmd = new SqlCommand("select * from Users where username='" + txtbox_Username.Text + "' and password='" + txtbox_Pass.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş başarılı");
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Giriş başarısız");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adnızı veya şifrenizi giriniz");
            }
        }
    }
}
