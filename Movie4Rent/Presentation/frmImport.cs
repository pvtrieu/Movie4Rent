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

        private void load()
        {
            currImport = new Importing();
            currImport.ImportDate = System.DateTime.Now;
            currImport.StaffID = frmMain._Pstaff.StaffID;
            ImportTableBind.DataSource = ImportBUS.getAll();
            ImportBind.DataSource = currImport;
            dgvImport.ClearSelection();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            load();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ImportBUS.Insert(currImport))
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
            currImport = ImportTableBind.Current as Importing;
            ImportBind.DataSource = currImport;
        }
    }
}
