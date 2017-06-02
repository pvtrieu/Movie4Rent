using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie4Rent.Entities;
using Movie4Rent.BUS;

namespace Movie4Rent.Presentation
{
    public partial class frmMain : Form
    {
        public static Staff _Pstaff;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(Staff staff)
        {
            InitializeComponent();
            _Pstaff = staff;
        }

        // Load another form to body panel
        private void addForm(Form currForm)
        {
            pnlBody.Controls.Clear();
            currForm.TopLevel = false;
            currForm.AutoScroll = false;
            currForm.Dock = DockStyle.Fill;
            currForm.AutoSize = false;
            this.pnlBody.Controls.Add(currForm);
            currForm.Show();
        }

        //Highlight selected button
        Button preBtn = new Button();
        private void SelectBtn(Button currBtn)
        {
            Color notSelectColor = Color.FromArgb(41, 53, 65);
            Color isSelectColor = Color.FromArgb(34, 42, 53);

            preBtn.BackColor = notSelectColor;
            currBtn.BackColor = isSelectColor;
            preBtn = currBtn;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            SelectBtn(btnMovie);
            frmMovie _form = new frmMovie();
            addForm(_form);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            SelectBtn(btnImport);
            frmImport _form = new frmImport();
            addForm(_form);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SelectBtn(btnExport);
            frmExport _form = new frmExport();
            addForm(_form);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin _frmLogin = new frmLogin();
            this.Hide();
            _frmLogin.ShowDialog();
            this.Close();

        }
    }
}
