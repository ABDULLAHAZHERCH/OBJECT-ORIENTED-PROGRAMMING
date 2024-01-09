namespace PACMAN
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.LivesBox = new System.Windows.Forms.TextBox();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.enemy1Health = new System.Windows.Forms.ProgressBar();
            this.enemy4Health = new System.Windows.Forms.ProgressBar();
            this.enemy3Health = new System.Windows.Forms.ProgressBar();
            this.enemy2Health = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnemyLoop = new System.Windows.Forms.Timer(this.components);
            this.uWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 200;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverLabel.Location = new System.Drawing.Point(510, 299);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(480, 95);
            this.GameOverLabel.TabIndex = 1;
            this.GameOverLabel.Text = "GAME OVER";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverLabel.Visible = false;
            this.GameOverLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LivesBox
            // 
            this.LivesBox.BackColor = System.Drawing.Color.Black;
            this.LivesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LivesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesBox.ForeColor = System.Drawing.Color.Chocolate;
            this.LivesBox.Location = new System.Drawing.Point(368, 753);
            this.LivesBox.Name = "LivesBox";
            this.LivesBox.ReadOnly = true;
            this.LivesBox.Size = new System.Drawing.Size(100, 32);
            this.LivesBox.TabIndex = 5;
            this.LivesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.BackColor = System.Drawing.Color.Transparent;
            this.LivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.ForeColor = System.Drawing.Color.Blue;
            this.LivesLabel.Location = new System.Drawing.Point(250, 753);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(99, 32);
            this.LivesLabel.TabIndex = 4;
            this.LivesLabel.Text = "LIVES";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.Black;
            this.mainMenuBtn.FlatAppearance.BorderSize = 3;
            this.mainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.mainMenuBtn.ForeColor = System.Drawing.Color.Blue;
            this.mainMenuBtn.Location = new System.Drawing.Point(1507, 12);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(201, 59);
            this.mainMenuBtn.TabIndex = 7;
            this.mainMenuBtn.Text = "MAIN MENU";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Blue;
            this.ScoreLabel.Location = new System.Drawing.Point(3, 753);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(119, 32);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "SCORE";
            // 
            // ScoreBox
            // 
            this.ScoreBox.BackColor = System.Drawing.Color.Black;
            this.ScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.ForeColor = System.Drawing.Color.Chocolate;
            this.ScoreBox.Location = new System.Drawing.Point(128, 753);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(100, 32);
            this.ScoreBox.TabIndex = 3;
            this.ScoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScoreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playerHealth
            // 
            this.playerHealth.Location = new System.Drawing.Point(753, 753);
            this.playerHealth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(178, 35);
            this.playerHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerHealth.TabIndex = 9;
            this.playerHealth.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(455, 753);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "PLAYER HEALTH";
            // 
            // enemy1Health
            // 
            this.enemy1Health.Location = new System.Drawing.Point(1522, 191);
            this.enemy1Health.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy1Health.Name = "enemy1Health";
            this.enemy1Health.Size = new System.Drawing.Size(178, 35);
            this.enemy1Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy1Health.TabIndex = 11;
            this.enemy1Health.Value = 100;
            // 
            // enemy4Health
            // 
            this.enemy4Health.Location = new System.Drawing.Point(1522, 468);
            this.enemy4Health.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy4Health.Name = "enemy4Health";
            this.enemy4Health.Size = new System.Drawing.Size(178, 35);
            this.enemy4Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy4Health.TabIndex = 13;
            this.enemy4Health.Value = 100;
            // 
            // enemy3Health
            // 
            this.enemy3Health.Location = new System.Drawing.Point(1522, 386);
            this.enemy3Health.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy3Health.Name = "enemy3Health";
            this.enemy3Health.Size = new System.Drawing.Size(178, 35);
            this.enemy3Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy3Health.TabIndex = 14;
            this.enemy3Health.Value = 100;
            // 
            // enemy2Health
            // 
            this.enemy2Health.Location = new System.Drawing.Point(1522, 283);
            this.enemy2Health.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy2Health.Name = "enemy2Health";
            this.enemy2Health.Size = new System.Drawing.Size(178, 35);
            this.enemy2Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy2Health.TabIndex = 15;
            this.enemy2Health.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1482, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enemy4 Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1482, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enemy3 Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1482, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Enemy2 Health";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1482, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enemy1 Health";
            // 
            // EnemyLoop
            // 
            this.EnemyLoop.Enabled = true;
            this.EnemyLoop.Interval = 500;
            this.EnemyLoop.Tick += new System.EventHandler(this.enemyLoop_Tick);
            // 
            // uWin
            // 
            this.uWin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uWin.AutoSize = true;
            this.uWin.BackColor = System.Drawing.Color.Transparent;
            this.uWin.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uWin.ForeColor = System.Drawing.Color.Red;
            this.uWin.Location = new System.Drawing.Point(574, 386);
            this.uWin.Name = "uWin";
            this.uWin.Size = new System.Drawing.Size(374, 95);
            this.uWin.TabIndex = 20;
            this.uWin.Text = "YOU WIN";
            this.uWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uWin.Visible = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1720, 883);
            this.Controls.Add(this.uWin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enemy2Health);
            this.Controls.Add(this.enemy3Health);
            this.Controls.Add(this.enemy4Health);
            this.Controls.Add(this.enemy1Health);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.LivesBox);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameOverLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOOTING TIME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.TextBox LivesBox;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar enemy1Health;
        private System.Windows.Forms.ProgressBar enemy4Health;
        private System.Windows.Forms.ProgressBar enemy3Health;
        private System.Windows.Forms.ProgressBar enemy2Health;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer EnemyLoop;
        private System.Windows.Forms.Label uWin;
    }
}

