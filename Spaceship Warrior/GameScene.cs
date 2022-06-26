using AxWMPLib;
using Spaceship_Warrior.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceship_Warrior
{
    [Serializable]
    class GameScene
    {
        public Player Player;
        public List<Enemy> Enemies;
        public List<Projectile> Projectiles;
        public AxWindowsMediaPlayer axwmp = new AxWindowsMediaPlayer();
        public bool GameEnded = false;
        public bool GameIsWon { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Score { get; set; }
        public int EnemiesDestroyed { get; set; }
        public int startY = 50;
        public int CurrentLevel { get; set; }
        
        public GameScene(int Height, int Width)
        {
            Enemies = new List<Enemy>();
            Projectiles = new List<Projectile>();
            this.Score = 0;
            this.Height = Height;
            this.Width = Width;
            Player = new Player(new Point(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height - 200 / 2));
            this.CurrentLevel = 0;
            GameIsWon = false;
        }

        public void PlayMusic(String MusicPath)
        {
            axwmp.CreateControl();
            axwmp.Enabled = true;
            axwmp.URL = Path.Combine(Path.GetFullPath(@"..\..\"), MusicPath);
            axwmp.settings.volume = 6;
            axwmp.Ctlcontrols.play();
        }

        public void SpawnEnemies(int level = 0)
        {
            Projectiles = new List<Projectile>();
            int startX;
            if (CurrentLevel == 3)
            {
                GameIsWon = true;
            }

            CurrentLevel++;
            if (CurrentLevel == 2)
            {
                Player.Lives += 1;
            }
            startY = 100 + level;
            Type type;
            Bitmap EnemySprite;
            for(int i = 0; i < CurrentLevel+2; i++)
            {
                startX = Width / 4;
                
                if (i == 0)
                {
                    type = Type.Level3;
                    EnemySprite = Resources.Level3;
                }
                else if (i == 1)
                {
                    type = Type.Level2;
                    EnemySprite = Resources.Level2;
                }
                else
                {
                    type = Type.Level1;
                    EnemySprite = Resources.Level1;
                }

                for (int j = 0; j < CurrentLevel+9; j++)
                {
                    
                    Enemies.Add(new Enemy(new Point(startX, startY), type ,EnemySprite));
                    startX += 120;
                }
                startY += 100;
            }
        }
        
        public void SpaceShipHitDetection()
        {

            if (Player.Lives <= 0)
            {
                GameEnded = true;
            }

            if (Enemies.Count == 0)
            {
                SpawnEnemies(50);
            }

            for (int i = 0; i < Enemies.Count; i++)
            {

                for (int j = 0; j < Projectiles.Count; j++)
                {
                    if (Projectiles[j].ProjectileHitbox.Y > Height || Projectiles[j].ProjectileHitbox.Y < 0)
                    {
                        Projectiles.Remove(Projectiles[j]);
                        continue;
                    }

                    if (i == Enemies.Count)
                    {
                        break;
                    }

                    if (Enemies[i].isHit(Projectiles[j]))
                        {
                            Enemies[i].Damage(Projectiles[j]);
                            
                            if (Enemies[i].Lives <= 0)
                            {

                                switch (Enemies[i].type)
                                {
                                    case (Type.Level1):
                                        Score += 10;
                                        break;

                                    case (Type.Level2):
                                        Score += 20;
                                        break;

                                    case (Type.Level3):
                                        Score += 30;
                                        break;
                                }
                                Enemies.Remove(Enemies[i]);
                                PlayMusic("Resources\\Audio\\DestroyEnemy.mp3");
                                EnemiesDestroyed++;
                            }
                            Projectiles.Remove(Projectiles[j]);
                            continue;
                        }
                        else if (Player.isHit(Projectiles[j]))
                        {
                            Player.Damage(Projectiles[j]);
                            Projectiles.Remove(Projectiles[j]);
                            continue;
                        }
                }
            }
        }

        public void StartGame()
        {
            Projectiles = new List<Projectile>();
            Enemies = new List<Enemy>();
            Player = new Player(new Point(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height - 200 / 2));
            Score = 0;
            SpawnEnemies();
            GameEnded = false;
        }

    }
}
