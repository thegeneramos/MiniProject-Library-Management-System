using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "Admin" && txtPass.Text == "1234")
            {
                MessageBox.Show("YOU SHALL PASS!");
                Library_Management_System objmain = new Library_Management_System();
                objmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("YOU SHALL NOT PASS! TRY AGAIN!", "WARNING");
                txtUser.Clear();
                txtPass.Clear();
            }
        }
    }
}
