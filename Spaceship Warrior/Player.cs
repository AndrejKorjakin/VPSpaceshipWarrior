using Spaceship_Warrior.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceship_Warrior
{

    enum playerControls
    {
        Left, Right
    }
    [Serializable]
    class Player : SpaceShip
    {

        public Player(Point center)
        {
            base.center = center;
            base.Sprite = new Bitmap(Resources.PlayerShip);
            this.CooldownTimer = new Stopwatch();
            this.CooldownTimer.Start();
            base.Lives = 3;

            base.Width = Sprite.Width;
            base.Height = Sprite.Height;

            base.Hitbox.X = this.center.X;
            base.Hitbox.Y = this.center.Y;
            base.Hitbox.Width = base.Width;
            base.Hitbox.Height = base.Height;
        }


        public override Projectile Fire()
        {
            Point shootingPoint = this.center;
            shootingPoint.X = this.center.X + Width / 2;
            Projectile p = new Projectile(shootingPoint);
            p.Damage = this.ProjectileDamage;
            p.isEnemyProjectile = false;
            return p;
        }
       
        public void Move(playerControls action)
        {
            switch (action)
            {
                case playerControls.Left:
                    if (this.center.X <= 0)
                    {
                        break;
                    }
                    base.center = new Point(center.X - 8, center.Y);
                    base.Hitbox.X = center.X;
                    break;

                case playerControls.Right:
                    if (this.center.X >= Screen.PrimaryScreen.WorkingArea.Right - this.Width)
                    {
                        break;
                    }
                    base.center = new Point(center.X + 8, center.Y);
                    base.Hitbox.X = center.X;
                    break;
            }
        }

        public override bool isHit(Projectile p)
        {
            if (this.Hitbox.IntersectsWith(p.ProjectileHitbox) && p.isEnemyProjectile)
            {
                return true;
            }
            else return false;
        }

        public void DrawLives(Graphics g)
        {
            int distance = 0;
            for (int i = 0; i < Lives; i++)
            {
                g.DrawImage(base.Sprite, Screen.PrimaryScreen.Bounds.Left + distance, Screen.PrimaryScreen.Bounds.Bottom - Height, base.Width, base.Height);
                distance += (Width + 20);
            }
        }
    }
}
