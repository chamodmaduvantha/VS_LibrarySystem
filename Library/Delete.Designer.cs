
namespace Library
{
    partial class Delete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldate = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.PDstudent = new System.Windows.Forms.Panel();
            this.txtDstudentsearch = new System.Windows.Forms.TextBox();
            this.DGVDstudent = new System.Windows.Forms.DataGridView();
            this.PDbook = new System.Windows.Forms.Panel();
            this.txtDbooksearch = new System.Windows.Forms.TextBox();
            this.DGVDbook = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.PDstudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDstudent)).BeginInit();
            this.PDbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDbook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 43);
            this.panel1.TabIndex = 3;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(875, 6);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(52, 24);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkOrange;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(135, -1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 41);
            this.button6.TabIndex = 1;
            this.button6.Text = "BOOK";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkOrange;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(-1, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 40);
            this.button9.TabIndex = 1;
            this.button9.Text = "STUDENT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // PDstudent
            // 
            this.PDstudent.BackgroundImage = global::Library.Properties.Resources.old_paper_background_hd_picture_2_169574;
            this.PDstudent.Controls.Add(this.txtDstudentsearch);
            this.PDstudent.Controls.Add(this.DGVDstudent);
            this.PDstudent.Location = new System.Drawing.Point(89, 116);
            this.PDstudent.Name = "PDstudent";
            this.PDstudent.Size = new System.Drawing.Size(840, 341);
            this.PDstudent.TabIndex = 4;
            this.PDstudent.Paint += new System.Windows.Forms.PaintEventHandler(this.PDstudent_Paint);
            // 
            // txtDstudentsearch
            // 
            this.txtDstudentsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDstudentsearch.Location = new System.Drawing.Point(601, 26);
            this.txtDstudentsearch.Name = "txtDstudentsearch";
            this.txtDstudentsearch.Size = new System.Drawing.Size(182, 29);
            this.txtDstudentsearch.TabIndex = 1;
            this.txtDstudentsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DGVDstudent
            // 
            this.DGVDstudent.BackgroundColor = System.Drawing.Color.White;
            this.DGVDstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDstudent.GridColor = System.Drawing.Color.Black;
            this.DGVDstudent.Location = new System.Drawing.Point(18, 107);
            this.DGVDstudent.Name = "DGVDstudent";
            this.DGVDstudent.Size = new System.Drawing.Size(804, 178);
            this.DGVDstudent.TabIndex = 0;
            this.DGVDstudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDstudent_CellClick);
            // 
            // PDbook
            // 
            this.PDbook.BackgroundImage = global::Library.Properties.Resources.old_paper_background_hd_picture_2_169574;
            this.PDbook.Controls.Add(this.txtDbooksearch);
            this.PDbook.Controls.Add(this.DGVDbook);
            this.PDbook.Location = new System.Drawing.Point(89, 116);
            this.PDbook.Name = "PDbook";
            this.PDbook.Size = new System.Drawing.Size(840, 341);
            this.PDbook.TabIndex = 5;
            this.PDbook.Paint += new System.Windows.Forms.PaintEventHandler(this.PDbook_Paint);
            // 
            // txtDbooksearch
            // 
            this.txtDbooksearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDbooksearch.Location = new System.Drawing.Point(598, 34);
            this.txtDbooksearch.Name = "txtDbooksearch";
            this.txtDbooksearch.Size = new System.Drawing.Size(182, 29);
            this.txtDbooksearch.TabIndex = 3;
            this.txtDbooksearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DGVDbook
            // 
            this.DGVDbook.BackgroundColor = System.Drawing.Color.White;
            this.DGVDbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDbook.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVDbook.Location = new System.Drawing.Point(15, 102);
            this.DGVDbook.Name = "DGVDbook";
            this.DGVDbook.Size = new System.Drawing.Size(804, 178);
            this.DGVDbook.TabIndex = 2;
            this.DGVDbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDbook_CellClick);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1003, 483);
            this.Controls.Add(this.PDbook);
            this.Controls.Add(this.PDstudent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PDstudent.ResumeLayout(false);
            this.PDstudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDstudent)).EndInit();
            this.PDbook.ResumeLayout(false);
            this.PDbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDbook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel PDstudent;
        private System.Windows.Forms.TextBox txtDstudentsearch;
        private System.Windows.Forms.DataGridView DGVDstudent;
        private System.Windows.Forms.Panel PDbook;
        private System.Windows.Forms.TextBox txtDbooksearch;
        private System.Windows.Forms.DataGridView DGVDbook;
    }
}