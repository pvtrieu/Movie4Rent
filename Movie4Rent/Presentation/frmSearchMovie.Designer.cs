namespace Movie4Rent.Presentation
{
    partial class frmSearchMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton1 = new Movie4Rent.Presentation.CloseButton();
            this.movePanel1 = new Movie4Rent.GUI_component.MovePanel();
            this.lblDirector = new System.Windows.Forms.Label();
            this.rtxtDesciption = new System.Windows.Forms.RichTextBox();
            this.MovieBind = new System.Windows.Forms.BindingSource(this.components);
            this.lblDesciption = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtIMDB = new System.Windows.Forms.TextBox();
            this.lblIMDB = new System.Windows.Forms.Label();
            this.txtGenres = new System.Windows.Forms.TextBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.pnlPoster = new System.Windows.Forms.Panel();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.MovieTableBind = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovieBind)).BeginInit();
            this.pnlPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieTableBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Movie";
            // 
            // closeButton1
            // 
            this.closeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.closeButton1.Location = new System.Drawing.Point(464, 12);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(24, 24);
            this.closeButton1.TabIndex = 8;
            // 
            // movePanel1
            // 
            this.movePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.movePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel1.Location = new System.Drawing.Point(0, 0);
            this.movePanel1.Name = "movePanel1";
            this.movePanel1.Size = new System.Drawing.Size(500, 50);
            this.movePanel1.TabIndex = 10;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblDirector.Location = new System.Drawing.Point(205, 99);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(71, 17);
            this.lblDirector.TabIndex = 58;
            this.lblDirector.Text = "Director:";
            // 
            // rtxtDesciption
            // 
            this.rtxtDesciption.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MovieBind, "Description", true));
            this.rtxtDesciption.Location = new System.Drawing.Point(313, 124);
            this.rtxtDesciption.Name = "rtxtDesciption";
            this.rtxtDesciption.Size = new System.Drawing.Size(166, 81);
            this.rtxtDesciption.TabIndex = 55;
            this.rtxtDesciption.Text = "";
            // 
            // MovieBind
            // 
            this.MovieBind.DataSource = typeof(Movie4Rent.Entities.Movie);
            // 
            // lblDesciption
            // 
            this.lblDesciption.AutoSize = true;
            this.lblDesciption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesciption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblDesciption.Location = new System.Drawing.Point(205, 125);
            this.lblDesciption.Name = "lblDesciption";
            this.lblDesciption.Size = new System.Drawing.Size(89, 17);
            this.lblDesciption.TabIndex = 57;
            this.lblDesciption.Text = "Desciption:";
            // 
            // txtDirector
            // 
            this.txtDirector.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MovieBind, "Director", true));
            this.txtDirector.Location = new System.Drawing.Point(313, 98);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(166, 20);
            this.txtDirector.TabIndex = 54;
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MovieBind, "Title", true));
            this.txtTitle.Location = new System.Drawing.Point(313, 72);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(166, 20);
            this.txtTitle.TabIndex = 53;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTitle.Location = new System.Drawing.Point(203, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 17);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Title:";
            // 
            // txtIMDB
            // 
            this.txtIMDB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MovieBind, "IMDB", true));
            this.txtIMDB.Location = new System.Drawing.Point(313, 211);
            this.txtIMDB.Name = "txtIMDB";
            this.txtIMDB.Size = new System.Drawing.Size(166, 20);
            this.txtIMDB.TabIndex = 70;
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblIMDB.Location = new System.Drawing.Point(205, 215);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(64, 17);
            this.lblIMDB.TabIndex = 75;
            this.lblIMDB.Text = "IMDB >:";
            // 
            // txtGenres
            // 
            this.txtGenres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MovieBind, "Genre", true));
            this.txtGenres.Location = new System.Drawing.Point(313, 237);
            this.txtGenres.Name = "txtGenres";
            this.txtGenres.Size = new System.Drawing.Size(166, 20);
            this.txtGenres.TabIndex = 71;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblActors.Location = new System.Drawing.Point(205, 263);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(59, 17);
            this.lblActors.TabIndex = 74;
            this.lblActors.Text = "Actors:";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblGenres.Location = new System.Drawing.Point(205, 238);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(66, 17);
            this.lblGenres.TabIndex = 73;
            this.lblGenres.Text = "Genres:";
            // 
            // txtActors
            // 
            this.txtActors.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MovieBind, "Actor", true));
            this.txtActors.Location = new System.Drawing.Point(313, 263);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(166, 20);
            this.txtActors.TabIndex = 72;
            // 
            // pnlPoster
            // 
            this.pnlPoster.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlPoster.Controls.Add(this.picPoster);
            this.pnlPoster.Location = new System.Drawing.Point(12, 72);
            this.pnlPoster.Name = "pnlPoster";
            this.pnlPoster.Size = new System.Drawing.Size(166, 211);
            this.pnlPoster.TabIndex = 76;
            // 
            // picPoster
            // 
            this.picPoster.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.MovieBind, "Poster", true));
            this.picPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPoster.Location = new System.Drawing.Point(0, 0);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(166, 211);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // MovieTableBind
            // 
            this.MovieTableBind.DataSource = typeof(Movie4Rent.Entities.Movie);
            // 
            // dgvMovie
            // 
            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.actorDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.iMDBDataGridViewTextBoxColumn});
            this.dgvMovie.DataSource = this.MovieTableBind;
            this.dgvMovie.Location = new System.Drawing.Point(12, 357);
            this.dgvMovie.MultiSelect = false;
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.ReadOnly = true;
            this.dgvMovie.Size = new System.Drawing.Size(467, 181);
            this.dgvMovie.TabIndex = 77;
            this.dgvMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovie_CellClick);
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            this.movieIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorDataGridViewTextBoxColumn
            // 
            this.actorDataGridViewTextBoxColumn.DataPropertyName = "Actor";
            this.actorDataGridViewTextBoxColumn.HeaderText = "Actor";
            this.actorDataGridViewTextBoxColumn.Name = "actorDataGridViewTextBoxColumn";
            this.actorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMDBDataGridViewTextBoxColumn
            // 
            this.iMDBDataGridViewTextBoxColumn.DataPropertyName = "IMDB";
            this.iMDBDataGridViewTextBoxColumn.HeaderText = "IMDB";
            this.iMDBDataGridViewTextBoxColumn.Name = "iMDBDataGridViewTextBoxColumn";
            this.iMDBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnSelect.Location = new System.Drawing.Point(379, 305);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 26);
            this.btnSelect.TabIndex = 79;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(208, 305);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 26);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearchMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvMovie);
            this.Controls.Add(this.pnlPoster);
            this.Controls.Add(this.txtIMDB);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.txtGenres);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.txtActors);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.rtxtDesciption);
            this.Controls.Add(this.lblDesciption);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.movePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchMovie";
            this.Text = "frmSearchMovie";
            this.Load += new System.EventHandler(this.frmSearchMovie_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmSearchMovie_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.MovieBind)).EndInit();
            this.pnlPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieTableBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CloseButton closeButton1;
        private GUI_component.MovePanel movePanel1;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.RichTextBox rtxtDesciption;
        private System.Windows.Forms.Label lblDesciption;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtIMDB;
        private System.Windows.Forms.Label lblIMDB;
        private System.Windows.Forms.TextBox txtGenres;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.Panel pnlPoster;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.BindingSource MovieBind;
        private System.Windows.Forms.BindingSource MovieTableBind;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
    }
}