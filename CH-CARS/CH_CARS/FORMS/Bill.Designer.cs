namespace CH_CARS.FORMS
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.priceBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.modelBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.companyBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(16)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(960, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1189, 100);
            this.panel2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "CH_CARS       ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(432, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILL GENERATED";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CH_CARS.Properties.Resources.pexels_mike_bird_120049;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1189, 669);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2HtmlLabel1.BackgroundImage")));
            this.guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(-48, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = null;
            // 
            // priceBox
            // 
            this.priceBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.priceBox.Animated = true;
            this.priceBox.BackColor = System.Drawing.Color.Transparent;
            this.priceBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("priceBox.BackgroundImage")));
            this.priceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.priceBox.BorderColor = System.Drawing.Color.Transparent;
            this.priceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceBox.DefaultText = "";
            this.priceBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.priceBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceBox.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceBox.Location = new System.Drawing.Point(18, 466);
            this.priceBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.priceBox.Name = "priceBox";
            this.priceBox.PasswordChar = '\0';
            this.priceBox.PlaceholderText = "";
            this.priceBox.ReadOnly = true;
            this.priceBox.SelectedText = "";
            this.priceBox.Size = new System.Drawing.Size(259, 50);
            this.priceBox.TabIndex = 35;
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modelBox
            // 
            this.modelBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modelBox.Animated = true;
            this.modelBox.BackColor = System.Drawing.Color.Transparent;
            this.modelBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modelBox.BackgroundImage")));
            this.modelBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modelBox.BorderColor = System.Drawing.Color.Transparent;
            this.modelBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modelBox.DefaultText = "";
            this.modelBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.modelBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.modelBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.modelBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.modelBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.modelBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modelBox.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.ForeColor = System.Drawing.Color.Black;
            this.modelBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modelBox.Location = new System.Drawing.Point(930, 239);
            this.modelBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.modelBox.Name = "modelBox";
            this.modelBox.PasswordChar = '\0';
            this.modelBox.PlaceholderText = "";
            this.modelBox.ReadOnly = true;
            this.modelBox.SelectedText = "";
            this.modelBox.Size = new System.Drawing.Size(259, 50);
            this.modelBox.TabIndex = 34;
            this.modelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // companyBox
            // 
            this.companyBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.companyBox.Animated = true;
            this.companyBox.BackColor = System.Drawing.Color.Transparent;
            this.companyBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("companyBox.BackgroundImage")));
            this.companyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.companyBox.BorderColor = System.Drawing.Color.Transparent;
            this.companyBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyBox.DefaultText = "";
            this.companyBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.companyBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.companyBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.companyBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companyBox.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyBox.ForeColor = System.Drawing.Color.Black;
            this.companyBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companyBox.Location = new System.Drawing.Point(930, 449);
            this.companyBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.companyBox.Name = "companyBox";
            this.companyBox.PasswordChar = '\0';
            this.companyBox.PlaceholderText = "";
            this.companyBox.ReadOnly = true;
            this.companyBox.SelectedText = "";
            this.companyBox.Size = new System.Drawing.Size(259, 50);
            this.companyBox.TabIndex = 33;
            this.companyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameBox.Animated = true;
            this.nameBox.BackColor = System.Drawing.Color.Transparent;
            this.nameBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameBox.BackgroundImage")));
            this.nameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nameBox.BorderColor = System.Drawing.Color.Transparent;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.DefaultText = "";
            this.nameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.nameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameBox.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameBox.Location = new System.Drawing.Point(18, 239);
            this.nameBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.PlaceholderText = "";
            this.nameBox.ReadOnly = true;
            this.nameBox.SelectedText = "";
            this.nameBox.Size = new System.Drawing.Size(259, 50);
            this.nameBox.TabIndex = 32;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(949, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 45);
            this.label4.TabIndex = 39;
            this.label4.Text = "Car Company";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(974, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 45);
            this.label3.TabIndex = 38;
            this.label3.Text = "Car Model";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 45);
            this.label5.TabIndex = 37;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 45);
            this.label6.TabIndex = 36;
            this.label6.Text = "Car Name";
            // 
            // printBtn
            // 
            this.printBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.printBtn.Animated = true;
            this.printBtn.AutoRoundedCorners = true;
            this.printBtn.BackColor = System.Drawing.Color.Transparent;
            this.printBtn.BorderRadius = 27;
            this.printBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.printBtn.DefaultAutoSize = true;
            this.printBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(16)))), ((int)(((byte)(120)))));
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(504, 601);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(208, 56);
            this.printBtn.TabIndex = 40;
            this.printBtn.Text = "PRINT BILL";
            this.printBtn.UseTransparentBackground = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
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
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(542, 52);
            this.label7.TabIndex = 41;
            this.label7.Text = "PSID : 0000XXXX0000X0";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1189, 669);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.companyBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1211, 725);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BILL";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox priceBox;
        private Guna.UI2.WinForms.Guna2TextBox modelBox;
        private Guna.UI2.WinForms.Guna2TextBox companyBox;
        private Guna.UI2.WinForms.Guna2TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label7;
    }
}