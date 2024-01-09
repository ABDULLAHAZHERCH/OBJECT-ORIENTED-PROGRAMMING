namespace CH_CARS.FORMS
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.signInbtn = new System.Windows.Forms.Button();
            this.signUpbtn = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signInbtn
            // 
            this.signInbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInbtn.BackColor = System.Drawing.Color.Black;
            this.signInbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signInbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.signInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInbtn.ForeColor = System.Drawing.Color.Red;
            this.signInbtn.Location = new System.Drawing.Point(790, 549);
            this.signInbtn.Name = "signInbtn";
            this.signInbtn.Size = new System.Drawing.Size(186, 58);
            this.signInbtn.TabIndex = 5;
            this.signInbtn.Text = "SIGN IN";
            this.signInbtn.UseVisualStyleBackColor = false;
            this.signInbtn.Click += new System.EventHandler(this.signInbtn_Click);
            // 
            // signUpbtn
            // 
            this.signUpbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpbtn.BackColor = System.Drawing.Color.Black;
            this.signUpbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signUpbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.signUpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpbtn.ForeColor = System.Drawing.Color.Red;
            this.signUpbtn.Location = new System.Drawing.Point(213, 549);
            this.signUpbtn.Name = "signUpbtn";
            this.signUpbtn.Size = new System.Drawing.Size(186, 58);
            this.signUpbtn.TabIndex = 4;
            this.signUpbtn.Text = "SIGN UP";
            this.signUpbtn.UseVisualStyleBackColor = false;
            this.signUpbtn.Click += new System.EventHandler(this.signUpbtn_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.Red;
            this.MainLabel.Location = new System.Drawing.Point(310, 62);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(557, 73);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "CHAUDHARY CARS";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CH_CARS.Properties.Resources.pexels_pixabay_38570;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 669);
            this.Controls.Add(this.signInbtn);
            this.Controls.Add(this.signUpbtn);
            this.Controls.Add(this.MainLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1211, 725);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInbtn;
        private System.Windows.Forms.Button signUpbtn;
        private System.Windows.Forms.Label MainLabel;
    }
}