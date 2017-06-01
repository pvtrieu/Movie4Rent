namespace Movie4Rent.Presentation
{
    partial class frmMain
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
            this.movePanel1 = new Movie4Rent.GUI_component.MovePanel();
            this.pndSideBar = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.closeButton1 = new Movie4Rent.Presentation.CloseButton();
            this.minimizeButton1 = new Movie4Rent.Presentation.MinimizeButton();
            this.expandButton1 = new Movie4Rent.Presentation.ExpandButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pndSideBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movePanel1
            // 
            this.movePanel1.BackColor = System.Drawing.Color.White;
            this.movePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel1.Location = new System.Drawing.Point(200, 0);
            this.movePanel1.Name = "movePanel1";
            this.movePanel1.Size = new System.Drawing.Size(800, 50);
            this.movePanel1.TabIndex = 0;
            // 
            // pndSideBar
            // 
            this.pndSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pndSideBar.Controls.Add(this.btnExport);
            this.pndSideBar.Controls.Add(this.btnImport);
            this.pndSideBar.Controls.Add(this.btnMovie);
            this.pndSideBar.Controls.Add(this.pnlLogo);
            this.pndSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pndSideBar.Location = new System.Drawing.Point(0, 0);
            this.pndSideBar.Name = "pndSideBar";
            this.pndSideBar.Size = new System.Drawing.Size(200, 780);
            this.pndSideBar.TabIndex = 1;
            this.pndSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 50);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnMovie
            // 
            this.btnMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.White;
            this.btnMovie.Location = new System.Drawing.Point(0, 50);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnMovie.Size = new System.Drawing.Size(200, 40);
            this.btnMovie.TabIndex = 1;
            this.btnMovie.Text = "Movie Info";
            this.btnMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovie.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(0, 90);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnImport.Size = new System.Drawing.Size(200, 40);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Importing";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(0, 130);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(200, 40);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exporting";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.Location = new System.Drawing.Point(964, 12);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(24, 24);
            this.closeButton1.TabIndex = 2;
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton1.Location = new System.Drawing.Point(904, 12);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(24, 24);
            this.minimizeButton1.TabIndex = 3;
            // 
            // expandButton1
            // 
            this.expandButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expandButton1.Location = new System.Drawing.Point(934, 12);
            this.expandButton1.Name = "expandButton1";
            this.expandButton1.Size = new System.Drawing.Size(24, 24);
            this.expandButton1.TabIndex = 4;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(200, 50);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(800, 730);
            this.pnlBody.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Movie4Rent.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie4Rent";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 780);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.expandButton1);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.movePanel1);
            this.Controls.Add(this.pndSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pndSideBar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI_component.MovePanel movePanel1;
        private System.Windows.Forms.Panel pndSideBar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private CloseButton closeButton1;
        private MinimizeButton minimizeButton1;
        private ExpandButton expandButton1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}