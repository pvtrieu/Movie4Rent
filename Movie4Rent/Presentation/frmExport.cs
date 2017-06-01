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
    public partial class frmExport : Form
    {
        Exporting currExport;
        public frmExport()
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
            currExport = new Exporting();
            currExport.ExportDate = System.DateTime.Now;
            currExport.StaffID = frmMain._Pstaff.StaffID;
            ExportTableBind.DataSource = ExportBUS.GetAll();
            DetailTableBind.DataSource = null;
            ExportBind.DataSource = currExport;
            dgvExport.ClearSelection();
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
            load();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currExport = ExportBind.Current as Exporting;
            if (ExportBUS.Insert(currExport))
            {
                MessageBox.Show("Success!");
                ExportTableBind.DataSource = ExportBUS.GetAll();

                //Select latest export
                int nRowIndex = dgvExport.Rows.Count - 2;
                dgvExport.CurrentCell = dgvExport.Rows[nRowIndex].Cells[0];
                dgvExport_CellClick(this.dgvExport, new DataGridViewCellEventArgs(nRowIndex, 0));

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
                if (ExportBUS.Delete(currExport))
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

        private void dgvExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            onBtn();
            currExport = ExportTableBind.Current as Exporting;
            ExportBind.DataSource = currExport;
            loadDetail(currExport);
        }

        ExportingDetail currDetail;
        private void loadDetail(Exporting export)
        {
            DetailTableBind.DataSource = ExportDetailBUS.GetAll(export);
            MovieBind.DataSource = MovieBUS.GetAll();
            currDetail = new ExportingDetail();
            currDetail.ExportID = export.ExportID;
            DetailBind.DataSource = currDetail;
            dgvExportDetail.ClearSelection();
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            currDetail = DetailBind.Current as ExportingDetail;
            if (ExportDetailBUS.Insert(currDetail))
            {
                MessageBox.Show("Success!");
                ExportBUS.Sum(currExport);
                loadDetail(currExport);
            }
            else
            {
                MessageBox.Show("Failed!");
            }
            
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            currDetail = DetailBind.Current as ExportingDetail;
            if (ExportDetailBUS.Update(currDetail))
            {
                MessageBox.Show("Success!");
                ExportBUS.Sum(currExport);
                loadDetail(currExport);
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
                currDetail = DetailBind.Current as ExportingDetail;
                if (ExportDetailBUS.Delete(currDetail))
                {
                    MessageBox.Show("Success!");
                    ExportBUS.Sum(currExport);
                    loadDetail(currExport);
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
        }

        private void dgvExportDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currDetail = DetailTableBind.Current as ExportingDetail;
            DetailBind.DataSource = currDetail;
        }

        private void frmExport_MouseClick(object sender, MouseEventArgs e)
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
