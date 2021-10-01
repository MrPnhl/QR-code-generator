namespace QR_Code_Maker
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.txttext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncreate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // txttext
            // 
            this.txttext.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.txttext.Location = new System.Drawing.Point(21, 88);
            this.txttext.Name = "txttext";
            this.txttext.Size = new System.Drawing.Size(331, 24);
            this.txttext.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(36, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter text or link \r\n(Mətn və ya keçid daxil edin)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btncreate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttext);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 127);
            this.panel1.TabIndex = 4;
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncreate.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.btncreate.Location = new System.Drawing.Point(448, 84);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(153, 37);
            this.btncreate.TabIndex = 79;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 80;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnprint);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 347);
            this.panel2.TabIndex = 5;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picturebox);
            this.panel3.Location = new System.Drawing.Point(21, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 306);
            this.panel3.TabIndex = 83;
            // 
            // picturebox
            // 
            this.picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturebox.Image = global::QR_Code_Maker.Properties.Resources.logo1;
            this.picturebox.Location = new System.Drawing.Point(0, 0);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(331, 306);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 81;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = global::QR_Code_Maker.Properties.Resources.icons8_print_48;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(541, 227);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(60, 50);
            this.btnprint.TabIndex = 82;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::QR_Code_Maker.Properties.Resources.floppy_disk;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(402, 283);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(199, 43);
            this.btnsave.TabIndex = 80;
            this.btnsave.Text = "     Save image as";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create your own QR code";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txttext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel3;
    }
}

