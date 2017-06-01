namespace Movie4Rent.Presentation
{
    partial class frmMovie
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
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPoster = new System.Windows.Forms.Panel();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lblDesciption = new System.Windows.Forms.Label();
            this.rtxtDesciption = new System.Windows.Forms.RichTextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.txtGenres = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lineSeparator2 = new Movie4Rent.Presentation.LineSeparator();
            this.lineSeparator1 = new Movie4Rent.Presentation.LineSeparator();
            this.pnlPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
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
            this.lblTopTitle.Size = new System.Drawing.Size(185, 26);
            this.lblTopTitle.TabIndex = 1;
            this.lblTopTitle.Text = "Movie Information";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(688, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 26);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.Red;
            this.btnImg.FlatAppearance.BorderSize = 0;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnImg.Location = new System.Drawing.Point(17, 346);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(211, 26);
            this.btnImg.TabIndex = 45;
            this.btnImg.Text = "Add poster";
            this.btnImg.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(535, 346);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 26);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(380, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 26);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(378, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(410, 20);
            this.txtTitle.TabIndex = 38;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTitle.Location = new System.Drawing.Point(268, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 17);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Title:";
            // 
            // pnlPoster
            // 
            this.pnlPoster.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlPoster.Controls.Add(this.picPoster);
            this.pnlPoster.Location = new System.Drawing.Point(17, 62);
            this.pnlPoster.Name = "pnlPoster";
            this.pnlPoster.Size = new System.Drawing.Size(211, 261);
            this.pnlPoster.TabIndex = 40;
            // 
            // picPoster
            // 
            this.picPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPoster.Location = new System.Drawing.Point(0, 0);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(211, 261);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lblDesciption
            // 
            this.lblDesciption.AutoSize = true;
            this.lblDesciption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesciption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblDesciption.Location = new System.Drawing.Point(270, 134);
            this.lblDesciption.Name = "lblDesciption";
            this.lblDesciption.Size = new System.Drawing.Size(89, 17);
            this.lblDesciption.TabIndex = 49;
            this.lblDesciption.Text = "Desciption:";
            // 
            // rtxtDesciption
            // 
            this.rtxtDesciption.Location = new System.Drawing.Point(378, 133);
            this.rtxtDesciption.Name = "rtxtDesciption";
            this.rtxtDesciption.Size = new System.Drawing.Size(410, 81);
            this.rtxtDesciption.TabIndex = 51;
            this.rtxtDesciption.Text = "";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblDirector.Location = new System.Drawing.Point(270, 98);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(71, 17);
            this.lblDirector.TabIndex = 52;
            this.lblDirector.Text = "Director:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(378, 97);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(410, 20);
            this.txtDirector.TabIndex = 38;
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblGenres.Location = new System.Drawing.Point(270, 267);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(66, 17);
            this.lblGenres.TabIndex = 53;
            this.lblGenres.Text = "Genres:";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblActors.Location = new System.Drawing.Point(270, 304);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(59, 17);
            this.lblActors.TabIndex = 65;
            this.lblActors.Text = "Actors:";
            // 
            // dgvMovie
            // 
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Location = new System.Drawing.Point(17, 407);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.Size = new System.Drawing.Size(771, 231);
            this.dgvMovie.TabIndex = 67;
            // 
            // txtActors
            // 
            this.txtActors.Location = new System.Drawing.Point(378, 304);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(410, 20);
            this.txtActors.TabIndex = 38;
            // 
            // txtGenres
            // 
            this.txtGenres.Location = new System.Drawing.Point(378, 266);
            this.txtGenres.Name = "txtGenres";
            this.txtGenres.Size = new System.Drawing.Size(410, 20);
            this.txtGenres.TabIndex = 68;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(378, 226);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(410, 20);
            this.txtQuantity.TabIndex = 70;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblQuantity.Location = new System.Drawing.Point(270, 227);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblQuantity.TabIndex = 69;
            this.lblQuantity.Text = "Quantity";
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(17, 388);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(771, 2);
            this.lineSeparator2.TabIndex = 66;
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
            // frmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtGenres);
            this.Controls.Add(this.dgvMovie);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.rtxtDesciption);
            this.Controls.Add(this.lblDesciption);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtActors);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlPoster);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTopTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovie";
            this.Text = "frmMovie";
            this.Load += new System.EventHandler(this.frmMovie_Load);
            this.pnlPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopTitle;
        private LineSeparator lineSeparator1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlPoster;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lblDesciption;
        private System.Windows.Forms.RichTextBox rtxtDesciption;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblActors;
        private LineSeparator lineSeparator2;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.TextBox txtGenres;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
    }
}