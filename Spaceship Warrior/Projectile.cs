using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship_Warrior
{
    [Serializable]
    class Projectile
    {
        public Point StartPoint;
        public Rectangle ProjectileHitbox;
        public bool isEnemyProjectile;
        public int SpeedOfProjectile = 10;
        public int Width = 9;
        public int Height = 30;
        public int Damage = 1;
       
        public Projectile(Point StartPoint)
        {
            this.StartPoint = StartPoint;
            ProjectileHitbox.X = StartPoint.X;
            ProjectileHitbox.Y = StartPoint.Y;
            ProjectileHitbox.Width = Width;
            ProjectileHitbox.Height = Height;
        }

        public Point getStartPoint()
        {
            return StartPoint;
        }

        public void Move()
        {
            if (isEnemyProjectile)
            {
                this.StartPoint.Y += SpeedOfProjectile;
                this.ProjectileHitbox.Y += SpeedOfProjectile;
            }
            else
            {
                this.StartPoint.Y -= SpeedOfProjectile;
                this.ProjectileHitbox.Y -= SpeedOfProjectile;
            }

        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Blue);
            if (isEnemyProjectile)
            {
                brush = new SolidBrush(Color.Red);
            }
            g.FillEllipse(brush, StartPoint.X, StartPoint.Y, Width, Height);
            brush.Dispose();
        }
    }
}
