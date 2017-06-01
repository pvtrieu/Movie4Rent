using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie4Rent.BUS;
using Movie4Rent.Entities;

namespace Movie4Rent.Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (StaffBUS.login(txtUsername.Text, txtPassword.Text)!= null)
            {
                frmMain _frmMain = new frmMain();
                this.Hide();
                _frmMain.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid username/password");
            }
        }

        
    }
}
