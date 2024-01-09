namespace CH_CARS.FORMS
{
    partial class BookBuy
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
            this.findBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findBtn
            // 
            this.findBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findBtn.AutoRoundedCorners = true;
            this.findBtn.BackColor = System.Drawing.Color.Transparent;
            this.findBtn.BorderRadius = 28;
            this.findBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.findBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.findBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.findBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.findBtn.FillColor = System.Drawing.Color.Turquoise;
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.findBtn.ForeColor = System.Drawing.Color.Black;
            this.findBtn.Location = new System.Drawing.Point(542, 350);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(129, 59);
            this.findBtn.TabIndex = 40;
            this.findBtn.Text = "Find";
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.AutoRoundedCorners = true;
            this.nameBox.BackColor = System.Drawing.Color.Transparent;
            this.nameBox.BorderRadius = 23;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.DefaultText = "";
            this.nameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameBox.FillColor = System.Drawing.Color.Turquoise;
            this.nameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameBox.Location = new System.Drawing.Point(514, 218);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.PlaceholderText = "";
            this.nameBox.SelectedText = "";
            this.nameBox.Size = new System.Drawing.Size(182, 48);
            this.nameBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Enter Car Name You Want to book for Buying";
            // 
            // BookBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(88)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1189, 669);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "BookBuy";
            this.Text = "BookBuy";
            this.Load += new System.EventHandler(this.BookBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button findBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameBox;
        private System.Windows.Forms.Label label1;
    }
}