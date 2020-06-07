using NoSql_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using NoSql_Model;

namespace desktop_app
{
    public partial class login : Form
    {
        #region login-brandon
        private User_Service user_Service = new User_Service();
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; 
            string password = txtPassword.Text;
            User user = user_Service.CheckUser(username, password);


            if (user != null)
            {
                this.Hide();
                Form1 form = new Form1(user);

                form.ShowDialog();
                this.Close();
            }
           else
            {
               MessageBox.Show("Login Unsuccessful, username/password does not match!");
            }
            
            
        }
        #endregion
    }
}
