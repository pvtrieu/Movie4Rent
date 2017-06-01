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
    public partial class frmImport : Form
    {
        Importing currImport;
        public frmImport()
        {
            InitializeComponent();
        }

        //Toggle Detail button    
        private void offBtn()
        {
            btnAddDetail.Enabled = false;
            btnUpdateDetail.Enabled = false;
            btnDeleteDetail.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void onBtn()
        {
            btnDelete.Enabled = true;
            btnAddDetail.Enabled = true;
            btnUpdateDetail.Enabled = true;
            btnDeleteDetail.Enabled = true;
        }

        private void load()
        {
            offBtn();
            currImport = new Importing();
            currImport.ImportDate = System.DateTime.Now;
            currImport.StaffID = frmMain._Pstaff.StaffID;
            ImportTableBind.DataSource = ImportBUS.GetAll();
            DetailTableBind.DataSource = null;
            ImportBind.DataSource = currImport;
            dgvImport.ClearSelection();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            load();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currImport = ImportBind.Current as Importing;
            if (ImportBUS.Insert(currImport))
            {
                MessageBox.Show("Success!");
                ImportTableBind.DataSource = ImportBUS.GetAll();

                //Select latest import
                int nRowIndex = dgvImport.Rows.Count - 2;
                dgvImport.CurrentCell = dgvImport.Rows[nRowIndex].Cells[0];
                dgvImport_CellClick(this.dgvImport, new DataGridViewCellEventArgs(nRowIndex, 0));

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
                if (ImportBUS.Delete(currImport))
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

        private void dgvImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            onBtn();
            currImport = ImportTableBind.Current as Importing;
            ImportBind.DataSource = currImport;
            loadDetail(currImport);
        }

        ImportingDetail currDetail;
        private void loadDetail(Importing import)
        {
            DetailTableBind.DataSource = ImportDetailBUS.GetAll(import);
            MovieBind.DataSource = MovieBUS.GetAll();
            currDetail = new ImportingDetail();
            currDetail.ImportID = import.ImportID;
            DetailBind.DataSource = currDetail;
            dgvImportDetail.ClearSelection();
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            currDetail = DetailBind.Current as ImportingDetail;
            if (ImportDetailBUS.Insert(currDetail))
            {
                MessageBox.Show("Success!");
                ImportBUS.Sum(currImport);
                loadDetail(currImport);
            }
            else
            {
                MessageBox.Show("Failed!");
            }
            
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            currDetail = DetailBind.Current as ImportingDetail;
            if (ImportDetailBUS.Update(currDetail))
            {
                MessageBox.Show("Success!");
                ImportBUS.Sum(currImport);
                loadDetail(currImport);
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                currDetail = DetailBind.Current as ImportingDetail;
                if (ImportDetailBUS.Delete(currDetail))
                {
                    MessageBox.Show("Success!");
                    ImportBUS.Sum(currImport);
                    loadDetail(currImport);
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
        }

        private void dgvImportDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currDetail = DetailTableBind.Current as ImportingDetail;
            DetailBind.DataSource = currDetail;
        }

        private void frmImport_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                load();
        }

        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            frmSearchMovie _frmSearchMovie = new frmSearchMovie();
            if (_frmSearchMovie.ShowDialog() == DialogResult.OK)
            {
                MovieBind.DataSource = _frmSearchMovie._movie;
            }
        }
    }
}
