using Spaceship_Warrior.Properties;
using System;
using System.Windows.Forms;
using AxWMPLib;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace Spaceship_Warrior
{
    public partial class Form1 : Form
    {
        AxWindowsMediaPlayer axwmp = new AxWindowsMediaPlayer();
        GameScene Scene;
        public List<int> HighScoreList;
        public Random Random = new Random();
        bool KeyLeft;
        bool KeyRight;
        bool KeyFire;
        bool pause = false;
        bool Direction;
        public int Height { get; set; }
        public int Width { get; set; }

        public Form1()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;

            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
            HighScoreList = new List<int>();

            StartGame();
            
        }

        public void StartGame()
        {
            Scene = new GameScene(Height, Width);
            PlayMusic("Resources\\Audio\\Dubmood - Afterburner.mp3");
            
            Scene.StartGame();
            GameTimer.Start();
            EnemyTimer.Start();
            ProjectileTimer.Start();

            PausePanel.Visible = false;
            PausePanel.BackColor = Color.FromArgb(150, 50, 50, 50);

            EndPanel.Visible = false;
            EndPanel.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - EndPanel.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - EndPanel.Height / 2);
            EndPanel.BackColor = Color.FromArgb(150, 50, 50, 50);

            HighScoresPanel.Visible = false;
            HighScoresPanel.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - EndPanel.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - EndPanel.Height / 2);
            HighScoresPanel.BackColor = Color.FromArgb(150, 50, 50, 50);

            WonPanel.Visible = false;
            WonPanel.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - EndPanel.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - EndPanel.Height / 2);
            WonPanel.BackColor = Color.FromArgb(150, 50, 50, 50);

        }

        public void EndGame()
        {
            EndPanel.Visible = true;
            StopMusic(axwmp);
            PlayMusic("Resources\\Audio\\GameOver.mp3");
            
            GameTimer.Stop();
            EnemyTimer.Stop();
            ProjectileTimer.Stop();

            HighScoreList.Add(Scene.Score);
        }

        public void GameWon()
        {
            WonPanel.Visible = true;
            PlayMusic("Resources\\Audio\\GameWon.mp3");

            GameTimer.Stop();
            EnemyTimer.Stop();
            ProjectileTimer.Stop();

            HighScoreList.Add(Scene.Score);
            WonLbl.Text = String.Format("With a total score of {0} points \n you have WON the game", Scene.Score);
        }

        public void PauseGame()
        {
            pause = !pause;
            if (pause)
            {
                PausePanel.Visible = true;
                GameTimer.Stop();
                EnemyTimer.Stop();
                ProjectileTimer.Stop();
            }
            else
            {
                PausePanel.Visible = false;
                this.Focus();
                GameTimer.Start();
                EnemyTimer.Start();
                ProjectileTimer.Start();
            }

        }

        public void StopMusic(AxWindowsMediaPlayer axwmp)
        {
            axwmp.Ctlcontrols.stop();
        }

        public void PlayMusic(String MusicPath)
        {

            axwmp.CreateControl();
            axwmp.Enabled = true;
            axwmp.URL = Path.Combine(Path.GetFullPath(@"..\..\"), MusicPath);
            
            if (MusicPath.Equals("Resources\\Audio\\Dubmood - Afterburner.mp3"))
            {
                axwmp.settings.setMode("loop", true);
            }
            else
            {
                axwmp.settings.setMode("loop", false);
            }
            
            axwmp.settings.volume = 6;
            axwmp.Ctlcontrols.play();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Invalidate(true);
            Scene.SpaceShipHitDetection();
            if (Scene.GameEnded)
            {
                EndGame();
            }
            if (Scene.GameIsWon)
            {
                GameWon();
            }
            KeyPressed();
            UpdateScoreEnemiesKilled();
        }

        private void PlayerTimer_Tick(object sender, EventArgs e)
        {

        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Scene.Enemies.Count; i++)
            {
                if (Scene.Enemies[i].center.X < 100)
                {
                    Direction = true;
                }
                if (Scene.Enemies[i].center.X > this.Width/1.15)
                {
                    Direction = false;
                }
            }

           
            foreach (Enemy enemy in Scene.Enemies)
            {
                int temp = Random.Next(1, 100);
                if(temp <= 30)
                {
                    Scene.Projectiles.Add(enemy.Fire());
                }

            }
        }

        private void ProjectileTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(Resources.galaxy_background, 0, 0);
            Scene.Player.Draw(e.Graphics);

            
            foreach (Enemy enemy in Scene.Enemies)
            {
                enemy.Move(Direction);
                enemy.Draw(e.Graphics);
            }
            
            foreach (Projectile p in Scene.Projectiles)
            {
                p.Move();
                p.Draw(e.Graphics);
            }

            Scene.Player.DrawLives(e.Graphics);
            e.Dispose();
        }

        public void KeyPressed()
        {
            if (KeyLeft)
            {
                Scene.Player.Move(playerControls.Left);

            }
            if (KeyRight)
            {
                Scene.Player.Move(playerControls.Right);

            }
            if (KeyFire)
            {
                if (Scene.Player.CooldownTimer.Elapsed.TotalMilliseconds >= Scene.Player.fireCooldown)
                {
                    Scene.Projectiles.Add(Scene.Player.Fire());
                    Scene.Player.CooldownTimer.Restart();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Left:
                    KeyLeft = true;
                    break;

                case Keys.Right:
                    KeyRight = true;
                    break;

                case Keys.Space:
                    KeyFire = true;
                    break;

                case Keys.Escape:
                    PauseGame();
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Left:
                    KeyLeft = false;
                    break;

                case Keys.Right:
                    KeyRight = false;
                    break;

                case Keys.Space:
                    KeyFire = false;
                    break;

            }
        }

        public void UpdateScoreEnemiesKilled()
        {
            ScoreLabel.Text = String.Format("Score: {0} Points", Scene.Score);
            EndScoreLbl.Text = String.Format("Score: {0}", Scene.Score);
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            StartGame();
            this.Focus();
        }

        private void RestartBtn2_Click(object sender, EventArgs e)
        {
            StartGame();
            this.Focus();
        }

        private void QuitBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HighScoreBtn_Click(object sender, EventArgs e)
        {
            HighScoresPanel.Visible = true;
            EndPanel.Visible = false;
            
            HighScoreLb.Items.Clear();
            HighScoreList.Sort();
            HighScoreList.Reverse();
            
            for (int i=0; i < HighScoreList.Count; i++)
            {
                HighScoreLb.Items.Add(HighScoreList[i] + " Points");
            }
            
        }

        private void HighScoresPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButtonHighScore_Click(object sender, EventArgs e)
        {
            HighScoresPanel.Visible = false;
            EndPanel.Visible = true;
        }

        private void RestartBtnWon_Click(object sender, EventArgs e)
        {
            StartGame();
            this.Focus();
        }

        private void QuitBtnWon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
