using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie4Rent.Entities;
using Movie4Rent.BUS;

namespace Movie4Rent.Presentation
{
    public partial class frmMovie : Form
    {
        Movie currMovie;
        public frmMovie()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            currMovie = new Movie();
            MovieBind.DataSource = currMovie;
            MovieTableBind.DataSource = MovieBUS.GetAll();
            dgvMovie.ClearSelection();
            txtQuantity.Clear();
        }
        private void frmMovie_Load(object sender, EventArgs e)
        {
            currMovie = new Movie();
        }

        //Convert image to byte for saving purpose
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        //convert byte to image for viewing
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currMovie.Poster = imageToByteArray(Image.FromFile(dialog.FileName));
                picPoster.Image = byteArrayToImage(currMovie.Poster);
            }
            MovieBind.DataSource = currMovie;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currMovie = MovieBind.Current as Movie;
            if (MovieBUS.Insert(currMovie))
            {
                MessageBox.Show("Success!");
                load();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MovieBUS.Update(currMovie))
            {
                MessageBox.Show("Success!");
                load();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MovieBUS.Delete(currMovie))
                {
                    MessageBox.Show("Done!");
                    load();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void dgvMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currMovie = MovieTableBind.Current as Movie;
            MovieBind.DataSource = currMovie;
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            frmSearchMovie _frmSearchMovie = new frmSearchMovie();
            if (_frmSearchMovie.ShowDialog() == DialogResult.OK)
            {
                currMovie = _frmSearchMovie._movie;
                MovieBind.DataSource = currMovie;
            }
        }

        private void frmMovie_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                load();
        }
    }
}
