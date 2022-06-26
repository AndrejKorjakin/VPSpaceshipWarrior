using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spaceship_Warrior
{
    [Serializable]
    class SpaceShip
    {
        public Point center;
        public Bitmap Sprite;
        public Rectangle Hitbox;
        public Stopwatch CooldownTimer;
        public int Height;
        public int Width;
        public int Lives = 1;
        public int Speed;
        public int ProjectileDamage = 1;
        public float fireCooldown = 400;

        public virtual Projectile Fire()
        {
            Point StartPoint = this.center;
            StartPoint.X = this.center.X + Width / 2;
            Projectile p = new Projectile(StartPoint);
            p.isEnemyProjectile = true;
            return p;
        }

        public void Damage(Projectile p)
        {
            this.Lives -= p.Damage;
        }

        public virtual bool isHit(Projectile p)
        {

            if (Hitbox.IntersectsWith(p.ProjectileHitbox) && !p.isEnemyProjectile)
            {
                return true;
            }
            else return false;

        }
        public void Draw(Graphics g)
        {
            g.DrawImage(image: Sprite, center.X, center.Y, Width, Height);
        }
    }
}
