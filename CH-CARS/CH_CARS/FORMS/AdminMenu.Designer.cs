namespace CH_CARS
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.seeUsers = new System.Windows.Forms.Button();
            this.updateRentbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.updateSalebtn = new System.Windows.Forms.Button();
            this.addRentCarsbtn = new System.Windows.Forms.Button();
            this.addSaleCarsbtn = new System.Windows.Forms.Button();
            this.carsonrentbtn = new System.Windows.Forms.Button();
            this.carsonsalebtn = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.childPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.childPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(16)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.seeUsers);
            this.panel1.Controls.Add(this.updateRentbtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.updateSalebtn);
            this.panel1.Controls.Add(this.addRentCarsbtn);
            this.panel1.Controls.Add(this.addSaleCarsbtn);
            this.panel1.Controls.Add(this.carsonrentbtn);
            this.panel1.Controls.Add(this.carsonsalebtn);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 775);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // seeUsers
            // 
            this.seeUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.seeUsers.FlatAppearance.BorderSize = 0;
            this.seeUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeUsers.ForeColor = System.Drawing.Color.White;
            this.seeUsers.Location = new System.Drawing.Point(0, 569);
            this.seeUsers.Name = "seeUsers";
            this.seeUsers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.seeUsers.Size = new System.Drawing.Size(229, 67);
            this.seeUsers.TabIndex = 11;
            this.seeUsers.Text = "Users Data";
            this.seeUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.seeUsers.UseVisualStyleBackColor = true;
            this.seeUsers.Click += new System.EventHandler(this.seeUsersbutton_Click);
            // 
            // updateRentbtn
            // 
            this.updateRentbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateRentbtn.FlatAppearance.BorderSize = 0;
            this.updateRentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRentbtn.ForeColor = System.Drawing.Color.White;
            this.updateRentbtn.Location = new System.Drawing.Point(0, 502);
            this.updateRentbtn.Name = "updateRentbtn";
            this.updateRentbtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.updateRentbtn.Size = new System.Drawing.Size(229, 67);
            this.updateRentbtn.TabIndex = 9;
            this.updateRentbtn.Text = "Update Rent Cars";
            this.updateRentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateRentbtn.UseVisualStyleBackColor = true;
            this.updateRentbtn.Click += new System.EventHandler(this.updateRentCars_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.LightGray;
            this.logoutbtn.Location = new System.Drawing.Point(0, 708);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(229, 67);
            this.logoutbtn.TabIndex = 8;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // updateSalebtn
            // 
            this.updateSalebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateSalebtn.FlatAppearance.BorderSize = 0;
            this.updateSalebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSalebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSalebtn.ForeColor = System.Drawing.Color.White;
            this.updateSalebtn.Location = new System.Drawing.Point(0, 435);
            this.updateSalebtn.Name = "updateSalebtn";
            this.updateSalebtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.updateSalebtn.Size = new System.Drawing.Size(229, 67);
            this.updateSalebtn.TabIndex = 7;
            this.updateSalebtn.Text = "Update Sale Cars";
            this.updateSalebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateSalebtn.UseVisualStyleBackColor = true;
            this.updateSalebtn.Click += new System.EventHandler(this.updateSaleCarsButton_Click);
            // 
            // addRentCarsbtn
            // 
            this.addRentCarsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRentCarsbtn.FlatAppearance.BorderSize = 0;
            this.addRentCarsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRentCarsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRentCarsbtn.ForeColor = System.Drawing.Color.White;
            this.addRentCarsbtn.Location = new System.Drawing.Point(0, 368);
            this.addRentCarsbtn.Name = "addRentCarsbtn";
            this.addRentCarsbtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.addRentCarsbtn.Size = new System.Drawing.Size(229, 67);
            this.addRentCarsbtn.TabIndex = 6;
            this.addRentCarsbtn.Text = "Add Rent Cars";
            this.addRentCarsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRentCarsbtn.UseVisualStyleBackColor = true;
            this.addRentCarsbtn.Click += new System.EventHandler(this.addRentCarsButton_Click);
            // 
            // addSaleCarsbtn
            // 
            this.addSaleCarsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSaleCarsbtn.FlatAppearance.BorderSize = 0;
            this.addSaleCarsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSaleCarsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleCarsbtn.ForeColor = System.Drawing.Color.White;
            this.addSaleCarsbtn.Location = new System.Drawing.Point(0, 301);
            this.addSaleCarsbtn.Name = "addSaleCarsbtn";
            this.addSaleCarsbtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.addSaleCarsbtn.Size = new System.Drawing.Size(229, 67);
            this.addSaleCarsbtn.TabIndex = 5;
            this.addSaleCarsbtn.Text = "Add Sale Cars";
            this.addSaleCarsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSaleCarsbtn.UseVisualStyleBackColor = true;
            this.addSaleCarsbtn.Click += new System.EventHandler(this.addSaleCarsButton_Click);
            // 
            // carsonrentbtn
            // 
            this.carsonrentbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.carsonrentbtn.FlatAppearance.BorderSize = 0;
            this.carsonrentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsonrentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsonrentbtn.ForeColor = System.Drawing.Color.White;
            this.carsonrentbtn.Location = new System.Drawing.Point(0, 234);
            this.carsonrentbtn.Name = "carsonrentbtn";
            this.carsonrentbtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.carsonrentbtn.Size = new System.Drawing.Size(229, 67);
            this.carsonrentbtn.TabIndex = 4;
            this.carsonrentbtn.Text = "Cars on Rent";
            this.carsonrentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carsonrentbtn.UseVisualStyleBackColor = true;
            this.carsonrentbtn.Click += new System.EventHandler(this.rentCarsButton_Click);
            // 
            // carsonsalebtn
            // 
            this.carsonsalebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.carsonsalebtn.FlatAppearance.BorderSize = 0;
            this.carsonsalebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsonsalebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsonsalebtn.ForeColor = System.Drawing.Color.White;
            this.carsonsalebtn.Location = new System.Drawing.Point(0, 167);
            this.carsonsalebtn.Name = "carsonsalebtn";
            this.carsonsalebtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.carsonsalebtn.Size = new System.Drawing.Size(229, 67);
            this.carsonsalebtn.TabIndex = 3;
            this.carsonsalebtn.Text = "Cars on Sale";
            this.carsonsalebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carsonsalebtn.UseVisualStyleBackColor = true;
            this.carsonsalebtn.Click += new System.EventHandler(this.saleCarsButton_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(0, 100);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(229, 67);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "CH_CARS       ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(16)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(960, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(355, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN MENU";
            // 
            // childPanel
            // 
            this.childPanel.BackColor = System.Drawing.Color.Transparent;
            this.childPanel.Controls.Add(this.label3);
            this.childPanel.Controls.Add(this.pictureBox1);
            this.childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanel.Location = new System.Drawing.Point(229, 100);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(960, 675);
            this.childPanel.TabIndex = 8;
            this.childPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(259, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 58);
            this.label3.TabIndex = 9;
            this.label3.Text = "CARS ARE DREAM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(156, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 435);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1189, 775);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1211, 760);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CH_CARS";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.childPanel.ResumeLayout(false);
            this.childPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button carsonsalebtn;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button updateSalebtn;
        private System.Windows.Forms.Button addRentCarsbtn;
        private System.Windows.Forms.Button addSaleCarsbtn;
        private System.Windows.Forms.Button carsonrentbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateRentbtn;
        private System.Windows.Forms.Panel childPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button seeUsers;
    }
}

