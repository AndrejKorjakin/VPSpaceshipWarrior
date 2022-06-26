namespace Spaceship_Warrior
{
    partial class Form1
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.ProjectileTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PausePanel = new System.Windows.Forms.Panel();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.EndPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EndScoreLbl = new System.Windows.Forms.Label();
            this.HighScoreBtn = new System.Windows.Forms.Button();
            this.QuitBtn2 = new System.Windows.Forms.Button();
            this.RestartBtn2 = new System.Windows.Forms.Button();
            this.HighScoresPanel = new System.Windows.Forms.Panel();
            this.BackButtonHighScore = new System.Windows.Forms.Button();
            this.HighScoreLb = new System.Windows.Forms.ListBox();
            this.HighScoreLblText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WonPanel = new System.Windows.Forms.Panel();
            this.QuitBtnWon = new System.Windows.Forms.Button();
            this.WonLbl = new System.Windows.Forms.Label();
            this.RestartBtnWon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PauseLbl = new System.Windows.Forms.Label();
            this.PausePanel.SuspendLayout();
            this.EndPanel.SuspendLayout();
            this.HighScoresPanel.SuspendLayout();
            this.WonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // PlayerTimer
            // 
            this.PlayerTimer.Tick += new System.EventHandler(this.PlayerTimer_Tick);
            // 
            // EnemyTimer
            // 
            this.EnemyTimer.Interval = 2000;
            this.EnemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // ProjectileTimer
            // 
            this.ProjectileTimer.Tick += new System.EventHandler(this.ProjectileTimer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(930, 35);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(35, 17);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Text";
            this.ScoreLabel.Click += new System.EventHandler(this.Score_Click);
            // 
            // PausePanel
            // 
            this.PausePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PausePanel.Controls.Add(this.PauseLbl);
            this.PausePanel.Controls.Add(this.RestartBtn);
            this.PausePanel.Controls.Add(this.QuitBtn);
            this.PausePanel.Controls.Add(this.ResumeBtn);
            this.PausePanel.Location = new System.Drawing.Point(694, 406);
            this.PausePanel.Name = "PausePanel";
            this.PausePanel.Size = new System.Drawing.Size(454, 304);
            this.PausePanel.TabIndex = 1;
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RestartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestartBtn.Location = new System.Drawing.Point(148, 164);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(149, 41);
            this.RestartBtn.TabIndex = 2;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuitBtn.Location = new System.Drawing.Point(148, 242);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(149, 41);
            this.QuitBtn.TabIndex = 1;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResumeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResumeBtn.Location = new System.Drawing.Point(148, 84);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(149, 41);
            this.ResumeBtn.TabIndex = 0;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = false;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // EndPanel
            // 
            this.EndPanel.Controls.Add(this.label2);
            this.EndPanel.Controls.Add(this.EndScoreLbl);
            this.EndPanel.Controls.Add(this.HighScoreBtn);
            this.EndPanel.Controls.Add(this.QuitBtn2);
            this.EndPanel.Controls.Add(this.RestartBtn2);
            this.EndPanel.Location = new System.Drawing.Point(67, 384);
            this.EndPanel.Name = "EndPanel";
            this.EndPanel.Size = new System.Drawing.Size(446, 326);
            this.EndPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(125, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "YOU LOST!";
            // 
            // EndScoreLbl
            // 
            this.EndScoreLbl.AutoSize = true;
            this.EndScoreLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EndScoreLbl.Location = new System.Drawing.Point(180, 292);
            this.EndScoreLbl.Name = "EndScoreLbl";
            this.EndScoreLbl.Size = new System.Drawing.Size(44, 13);
            this.EndScoreLbl.TabIndex = 5;
            this.EndScoreLbl.Text = "SCORE";
            // 
            // HighScoreBtn
            // 
            this.HighScoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HighScoreBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HighScoreBtn.Location = new System.Drawing.Point(131, 68);
            this.HighScoreBtn.Name = "HighScoreBtn";
            this.HighScoreBtn.Size = new System.Drawing.Size(149, 41);
            this.HighScoreBtn.TabIndex = 4;
            this.HighScoreBtn.Text = "High Scores";
            this.HighScoreBtn.UseVisualStyleBackColor = false;
            this.HighScoreBtn.Click += new System.EventHandler(this.HighScoreBtn_Click);
            // 
            // QuitBtn2
            // 
            this.QuitBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuitBtn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuitBtn2.Location = new System.Drawing.Point(131, 218);
            this.QuitBtn2.Name = "QuitBtn2";
            this.QuitBtn2.Size = new System.Drawing.Size(149, 41);
            this.QuitBtn2.TabIndex = 3;
            this.QuitBtn2.Text = "Quit";
            this.QuitBtn2.UseVisualStyleBackColor = false;
            this.QuitBtn2.Click += new System.EventHandler(this.QuitBtn2_Click);
            // 
            // RestartBtn2
            // 
            this.RestartBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RestartBtn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestartBtn2.Location = new System.Drawing.Point(131, 140);
            this.RestartBtn2.Name = "RestartBtn2";
            this.RestartBtn2.Size = new System.Drawing.Size(149, 41);
            this.RestartBtn2.TabIndex = 3;
            this.RestartBtn2.Text = "Restart";
            this.RestartBtn2.UseVisualStyleBackColor = false;
            this.RestartBtn2.Click += new System.EventHandler(this.RestartBtn2_Click);
            // 
            // HighScoresPanel
            // 
            this.HighScoresPanel.Controls.Add(this.BackButtonHighScore);
            this.HighScoresPanel.Controls.Add(this.HighScoreLb);
            this.HighScoresPanel.Controls.Add(this.HighScoreLblText);
            this.HighScoresPanel.Controls.Add(this.label1);
            this.HighScoresPanel.Location = new System.Drawing.Point(541, 22);
            this.HighScoresPanel.Name = "HighScoresPanel";
            this.HighScoresPanel.Size = new System.Drawing.Size(327, 378);
            this.HighScoresPanel.TabIndex = 3;
            this.HighScoresPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HighScoresPanel_Paint);
            // 
            // BackButtonHighScore
            // 
            this.BackButtonHighScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackButtonHighScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButtonHighScore.Location = new System.Drawing.Point(72, 324);
            this.BackButtonHighScore.Name = "BackButtonHighScore";
            this.BackButtonHighScore.Size = new System.Drawing.Size(149, 41);
            this.BackButtonHighScore.TabIndex = 6;
            this.BackButtonHighScore.Text = "Back";
            this.BackButtonHighScore.UseVisualStyleBackColor = false;
            this.BackButtonHighScore.Click += new System.EventHandler(this.BackButtonHighScore_Click);
            // 
            // HighScoreLb
            // 
            this.HighScoreLb.BackColor = System.Drawing.SystemColors.InfoText;
            this.HighScoreLb.ForeColor = System.Drawing.SystemColors.Menu;
            this.HighScoreLb.FormattingEnabled = true;
            this.HighScoreLb.Location = new System.Drawing.Point(44, 61);
            this.HighScoreLb.Name = "HighScoreLb";
            this.HighScoreLb.Size = new System.Drawing.Size(206, 251);
            this.HighScoreLb.TabIndex = 2;
            // 
            // HighScoreLblText
            // 
            this.HighScoreLblText.AutoSize = true;
            this.HighScoreLblText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HighScoreLblText.Location = new System.Drawing.Point(72, 74);
            this.HighScoreLblText.Name = "HighScoreLblText";
            this.HighScoreLblText.Size = new System.Drawing.Size(0, 13);
            this.HighScoreLblText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(110, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "High Scores";
            // 
            // WonPanel
            // 
            this.WonPanel.Controls.Add(this.QuitBtnWon);
            this.WonPanel.Controls.Add(this.WonLbl);
            this.WonPanel.Controls.Add(this.RestartBtnWon);
            this.WonPanel.Controls.Add(this.label3);
            this.WonPanel.Location = new System.Drawing.Point(45, 14);
            this.WonPanel.Name = "WonPanel";
            this.WonPanel.Size = new System.Drawing.Size(467, 340);
            this.WonPanel.TabIndex = 4;
            // 
            // QuitBtnWon
            // 
            this.QuitBtnWon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuitBtnWon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuitBtnWon.Location = new System.Drawing.Point(144, 282);
            this.QuitBtnWon.Name = "QuitBtnWon";
            this.QuitBtnWon.Size = new System.Drawing.Size(149, 41);
            this.QuitBtnWon.TabIndex = 6;
            this.QuitBtnWon.Text = "Quit";
            this.QuitBtnWon.UseVisualStyleBackColor = false;
            this.QuitBtnWon.Click += new System.EventHandler(this.QuitBtnWon_Click);
            // 
            // WonLbl
            // 
            this.WonLbl.AutoSize = true;
            this.WonLbl.BackColor = System.Drawing.Color.Transparent;
            this.WonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WonLbl.Location = new System.Drawing.Point(122, 86);
            this.WonLbl.Name = "WonLbl";
            this.WonLbl.Size = new System.Drawing.Size(158, 25);
            this.WonLbl.TabIndex = 1;
            this.WonLbl.Text = "With the score of";
            // 
            // RestartBtnWon
            // 
            this.RestartBtnWon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RestartBtnWon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestartBtnWon.Location = new System.Drawing.Point(144, 204);
            this.RestartBtnWon.Name = "RestartBtnWon";
            this.RestartBtnWon.Size = new System.Drawing.Size(149, 41);
            this.RestartBtnWon.TabIndex = 7;
            this.RestartBtnWon.Text = "Restart";
            this.RestartBtnWon.UseVisualStyleBackColor = false;
            this.RestartBtnWon.Click += new System.EventHandler(this.RestartBtnWon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(120, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "You have WON!";
            // 
            // PauseLbl
            // 
            this.PauseLbl.AutoSize = true;
            this.PauseLbl.BackColor = System.Drawing.Color.Transparent;
            this.PauseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseLbl.Location = new System.Drawing.Point(165, 13);
            this.PauseLbl.Name = "PauseLbl";
            this.PauseLbl.Size = new System.Drawing.Size(106, 31);
            this.PauseLbl.TabIndex = 3;
            this.PauseLbl.Text = "Paused";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1212, 753);
            this.Controls.Add(this.WonPanel);
            this.Controls.Add(this.HighScoresPanel);
            this.Controls.Add(this.EndPanel);
            this.Controls.Add(this.PausePanel);
            this.Controls.Add(this.ScoreLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PausePanel.ResumeLayout(false);
            this.PausePanel.PerformLayout();
            this.EndPanel.ResumeLayout(false);
            this.EndPanel.PerformLayout();
            this.HighScoresPanel.ResumeLayout(false);
            this.HighScoresPanel.PerformLayout();
            this.WonPanel.ResumeLayout(false);
            this.WonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer PlayerTimer;
        private System.Windows.Forms.Timer EnemyTimer;
        private System.Windows.Forms.Timer ProjectileTimer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel PausePanel;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Panel EndPanel;
        private System.Windows.Forms.Button QuitBtn2;
        private System.Windows.Forms.Button RestartBtn2;
        private System.Windows.Forms.Button HighScoreBtn;
        private System.Windows.Forms.Label EndScoreLbl;
        private System.Windows.Forms.Panel HighScoresPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HighScoreLblText;
        private System.Windows.Forms.ListBox HighScoreLb;
        private System.Windows.Forms.Button BackButtonHighScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel WonPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WonLbl;
        private System.Windows.Forms.Button QuitBtnWon;
        private System.Windows.Forms.Button RestartBtnWon;
        private System.Windows.Forms.Label PauseLbl;
    }
}

