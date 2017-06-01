using Movie4Rent.BUS;
using Movie4Rent.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie4Rent.Presentation
{
    public partial class frmSearchMovie : Form
    {
        public Movie _movie;
        private bool check;
        public frmSearchMovie()
        {
            InitializeComponent();
        }
        
        private void load()
        {
            check = false;
            MovieBind.DataSource = new Movie();
            MovieTableBind.DataSource = MovieBUS.GetAll();
            dgvMovie.ClearSelection();
        }
        private void frmSearchMovie_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MovieTableBind.DataSource = MovieBUS.Search(MovieBind.Current as Movie);
        }

        private void frmSearchMovie_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                load();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (check)
            {
                _movie = MovieBind.Current as Movie;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Please select a movie on table");
        }

        private void dgvMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MovieBind.DataSource = MovieTableBind.Current as Movie;
            check = true;
        }
    }
}
