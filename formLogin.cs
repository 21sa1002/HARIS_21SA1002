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

namespace Toko_Bangunan_Watumas_Jaya
{
    public partial class formLogin : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DL0NFGV\ANGGA;Initial Catalog=tokoBangunan;Integrated Security=True");
        public formLogin()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            txtWarning.Visible = false;
        }

        private bool Login(string username, string password)
        {
            bool success = false;

            try
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM tbKaryawan WHERE username=@username AND passwd=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return success;
        }

        formMenu frmMenu;

        void formMenu_close(object sender, FormClosedEventArgs e)
        {
            frmMenu = null;
        }

        private void btMasuk_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPasswd.Text;

            bool loginSuccess = Login(username, password);

            if (loginSuccess)
            {
                MessageBox.Show("Login berhasil!");
                if (frmMenu == null)
                {
                    frmMenu = new formMenu();
                    frmMenu.FormClosed += new FormClosedEventHandler(formMenu_close);
                    frmMenu.ShowDialog();
                }
                else
                {
                    frmMenu.Activate();
                }
                // Misalnya, pindah ke form utama
                // this.Hide();
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
            }
            else
            {
                txtWarning.Visible = true;
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
