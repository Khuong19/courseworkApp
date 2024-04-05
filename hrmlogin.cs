using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class hrmlogin : Form
    {
        public hrmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_login(object sender, EventArgs e)
        {
            //Check for tb_username and tb_password are empty or not
            if (tb_username != null && tb_username.Text.Trim() != "") { }
            else {
                MessageBox.Show("Please enter username!");
                tb_username.Focus(); //Enter the text without clicking mouse on it
                return;
            }
            if (tb_password != null && tb_password.Text.Trim() != "") { }
            else
            {
                MessageBox.Show("Please enter password!");
                tb_password.Focus(); //Enter the text without clicking mouse on it
                return;
            }
            //Compare user login information to the data in login table
            hrmmain _hrmmain = new hrmmain();
            _hrmmain.Show();
            this.Hide();

        }
    }
}
