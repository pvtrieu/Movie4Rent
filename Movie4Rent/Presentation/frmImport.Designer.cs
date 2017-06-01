namespace Movie4Rent.Presentation
{
    partial class frmImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lineSeparator1 = new Movie4Rent.Presentation.LineSeparator();
            this.lineSeparator2 = new Movie4Rent.Presentation.LineSeparator();
            this.dgvImportDetail = new System.Windows.Forms.DataGridView();
            this.importIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailTableBind = new System.Windows.Forms.BindingSource(this.components);
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.importIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportTableBind = new System.Windows.Forms.BindingSource(this.components);
            this.dateImport = new System.Windows.Forms.DateTimePicker();
            this.ImportBind = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotalQuant = new System.Windows.Forms.TextBox();
            this.lblTotalQuant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.DetailBind = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.MovieBind = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnSearchMovie = new Movie4Rent.GUI_component.SearchButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailTableBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportTableBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieBind)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTopTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(109, 26);
            this.lblTopTitle.TabIndex = 1;
            this.lblTopTitle.Text = "Importing:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(688, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 26);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(436, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 26);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTitle.Location = new System.Drawing.Point(433, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 17);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Date:";
            // 
            // lineSeparator1
            // 
            this.lineSeparator1.Location = new System.Drawing.Point(17, 38);
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.Size = new System.Drawing.Size(771, 2);
            this.lineSeparator1.TabIndex = 2;
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(17, 340);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(771, 2);
            this.lineSeparator2.TabIndex = 66;
            // 
            // dgvImportDetail
            // 
            this.dgvImportDetail.AutoGenerateColumns = false;
            this.dgvImportDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importIDDataGridViewTextBoxColumn1,
            this.movieIDDataGridViewTextBoxColumn,
            this.quantDataGridViewTextBoxColumn});
            this.dgvImportDetail.DataSource = this.DetailTableBind;
            this.dgvImportDetail.Location = new System.Drawing.Point(17, 362);
            this.dgvImportDetail.Name = "dgvImportDetail";
            this.dgvImportDetail.Size = new System.Drawing.Size(380, 270);
            this.dgvImportDetail.TabIndex = 67;
            this.dgvImportDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportDetail_CellClick);
            // 
            // importIDDataGridViewTextBoxColumn1
            // 
            this.importIDDataGridViewTextBoxColumn1.DataPropertyName = "ImportID";
            this.importIDDataGridViewTextBoxColumn1.HeaderText = "ImportID";
            this.importIDDataGridViewTextBoxColumn1.Name = "importIDDataGridViewTextBoxColumn1";
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            // 
            // quantDataGridViewTextBoxColumn
            // 
            this.quantDataGridViewTextBoxColumn.DataPropertyName = "Quant";
            this.quantDataGridViewTextBoxColumn.HeaderText = "Quant";
            this.quantDataGridViewTextBoxColumn.Name = "quantDataGridViewTextBoxColumn";
            // 
            // DetailTableBind
            // 
            this.DetailTableBind.DataSource = typeof(Movie4Rent.Entities.ImportingDetail);
            // 
            // dgvImport
            // 
            this.dgvImport.AutoGenerateColumns = false;
            this.dgvImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importIDDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.importDateDataGridViewTextBoxColumn,
            this.totalQuantDataGridViewTextBoxColumn});
            this.dgvImport.DataSource = this.ImportTableBind;
            this.dgvImport.Location = new System.Drawing.Point(17, 61);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.Size = new System.Drawing.Size(380, 261);
            this.dgvImport.TabIndex = 68;
            this.dgvImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImport_CellClick);
            // 
            // importIDDataGridViewTextBoxColumn
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(572, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // importDateDataGridViewTextBoxColumn
            // 
            this.importDateDataGridViewTextBoxColumn.DataPropertyName = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.HeaderText = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.Name = "importDateDataGridViewTextBoxColumn";
            // 
            // totalQuantDataGridViewTextBoxColumn
            // 
            this.totalQuantDataGridViewTextBoxColumn.DataPropertyName = "TotalQuant";
            this.totalQuantDataGridViewTextBoxColumn.HeaderText = "TotalQuant";
            this.totalQuantDataGridViewTextBoxColumn.Name = "totalQuantDataGridViewTextBoxColumn";
            // 
            // ImportTableBind
            // 
            this.ImportTableBind.DataSource = typeof(Movie4Rent.Entities.Importing);
            // 
            // dateImport
            // 
            this.dateImport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ImportBind, "ImportDate", true));
            this.dateImport.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ImportBind, "ImportDate", true));
            this.dateImport.Location = new System.Drawing.Point(572, 61);
            this.dateImport.Name = "dateImport";
            this.dateImport.Size = new System.Drawing.Size(214, 20);
            this.dateImport.TabIndex = 69;
            // 
            // ImportBind
            // 
            this.ImportBind.DataSource = typeof(Movie4Rent.Entities.Importing);
            // 
            // txtTotalQuant
            // 
            this.txtTotalQuant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ImportBind, "TotalQuant", true));
            this.txtTotalQuant.Location = new System.Drawing.Point(572, 124);
            this.txtTotalQuant.Name = "txtTotalQuant";
            this.txtTotalQuant.ReadOnly = true;
            this.txtTotalQuant.Size = new System.Drawing.Size(214, 20);
            this.txtTotalQuant.TabIndex = 38;
            // 
            // lblTotalQuant
            // 
            this.lblTotalQuant.AutoSize = true;
            this.lblTotalQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTotalQuant.Location = new System.Drawing.Point(433, 124);
            this.lblTotalQuant.Name = "lblTotalQuant";
            this.lblTotalQuant.Size = new System.Drawing.Size(116, 17);
            this.lblTotalQuant.TabIndex = 52;
            this.lblTotalQuant.Text = "Total Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(433, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "StaffID:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ImportBind, "StaffID", true));
            this.txtStaffID.Location = new System.Drawing.Point(572, 188);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(214, 20);
            this.txtStaffID.TabIndex = 70;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblQuantity.Location = new System.Drawing.Point(435, 418);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 17);
            this.lblQuantity.TabIndex = 73;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DetailBind, "Quant", true));
            this.txtQuantity.Location = new System.Drawing.Point(574, 418);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(214, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // DetailBind
            // 
            this.DetailBind.DataSource = typeof(Movie4Rent.Entities.ImportingDetail);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(435, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Movie:";
            // 
            // cboMovie
            // 
            this.cboMovie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.DetailBind, "MovieID", true));
            this.cboMovie.DataSource = this.MovieBind;
            this.cboMovie.DisplayMember = "Title";
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Location = new System.Drawing.Point(574, 362);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(186, 21);
            this.cboMovie.TabIndex = 0;
            this.cboMovie.ValueMember = "MovieID";
            // 
            // MovieBind
            // 
            this.MovieBind.DataSource = typeof(Movie4Rent.Entities.Movie);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.BackColor = System.Drawing.Color.Red;
            this.btnDeleteDetail.FlatAppearance.BorderSize = 0;
            this.btnDeleteDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDeleteDetail.Location = new System.Drawing.Point(688, 491);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(100, 26);
            this.btnDeleteDetail.TabIndex = 4;
            this.btnDeleteDetail.Text = "Delete";
            this.btnDeleteDetail.UseVisualStyleBackColor = false;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdateDetail.FlatAppearance.BorderSize = 0;
            this.btnUpdateDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdateDetail.Location = new System.Drawing.Point(561, 491);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(100, 26);
            this.btnUpdateDetail.TabIndex = 3;
            this.btnUpdateDetail.Text = "Update";
            this.btnUpdateDetail.UseVisualStyleBackColor = false;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAddDetail.FlatAppearance.BorderSize = 0;
            this.btnAddDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAddDetail.Location = new System.Drawing.Point(436, 491);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(100, 26);
            this.btnAddDetail.TabIndex = 2;
            this.btnAddDetail.Text = "Add";
            this.btnAddDetail.UseVisualStyleBackColor = false;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.Location = new System.Drawing.Point(771, 362);
            this.btnSearchMovie.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(20, 20);
            this.btnSearchMovie.TabIndex = 75;
            this.btnSearchMovie.ButtonClick += new System.EventHandler(this.btnSearchMovie_Click);
            this.btnSearchMovie.Click += new System.EventHandler(this.btnSearchMovie_Click);
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.btnSearchMovie);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.btnUpdateDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.dateImport);
            this.Controls.Add(this.dgvImport);
            this.Controls.Add(this.dgvImportDetail);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.lblTotalQuant);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalQuant);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTopTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmImport_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailTableBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportTableBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieBind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopTitle;
        private LineSeparator lineSeparator1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private LineSeparator lineSeparator2;
        private System.Windows.Forms.DataGridView dgvImportDetail;
        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.DateTimePicker dateImport;
        private System.Windows.Forms.TextBox txtTotalQuant;
        private System.Windows.Forms.Label lblTotalQuant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.BindingSource ImportBind;
        private System.Windows.Forms.DataGridViewTextBoxColumn importIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ImportTableBind;
        private System.Windows.Forms.DataGridViewTextBoxColumn importIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource DetailTableBind;
        private System.Windows.Forms.BindingSource DetailBind;
        private System.Windows.Forms.BindingSource MovieBind;
        private GUI_component.SearchButton btnSearchMovie;
    }
}