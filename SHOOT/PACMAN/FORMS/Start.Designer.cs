﻿namespace PACMAN
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.gameLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.insructBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLbl
            // 
            this.gameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameLbl.AutoSize = true;
            this.gameLbl.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLbl.ForeColor = System.Drawing.Color.Red;
            this.gameLbl.Location = new System.Drawing.Point(337, 49);
            this.gameLbl.Name = "gameLbl";
            this.gameLbl.Size = new System.Drawing.Size(632, 95);
            this.gameLbl.TabIndex = 0;
            this.gameLbl.Text = "SHOOTING TIME";
            this.gameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameLbl.Click += new System.EventHandler(this.gameLbl_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startBtn.BackColor = System.Drawing.Color.Black;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.Blue;
            this.startBtn.Location = new System.Drawing.Point(480, 289);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(360, 84);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // insructBtn
            // 
            this.insructBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insructBtn.BackColor = System.Drawing.Color.Black;
            this.insructBtn.FlatAppearance.BorderSize = 0;
            this.insructBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insructBtn.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insructBtn.ForeColor = System.Drawing.Color.Blue;
            this.insructBtn.Location = new System.Drawing.Point(480, 406);
            this.insructBtn.Name = "insructBtn";
            this.insructBtn.Size = new System.Drawing.Size(360, 84);
            this.insructBtn.TabIndex = 2;
            this.insructBtn.Text = "INSTRUCTIONS";
            this.insructBtn.UseVisualStyleBackColor = true;
            this.insructBtn.Click += new System.EventHandler(this.insructBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.BackColor = System.Drawing.Color.Black;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Blue;
            this.exitBtn.Location = new System.Drawing.Point(480, 527);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(360, 84);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.GameOverLabel.Location = new System.Drawing.Point(294, 173);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(711, 58);
            this.GameOverLabel.TabIndex = 4;
            this.GameOverLabel.Text = "There is a Time For EveryThing";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1282, 669);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.insructBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.gameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1304, 725);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOOT";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button insructBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label GameOverLabel;
    }
}