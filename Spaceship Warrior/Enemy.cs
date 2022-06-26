using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceship_Warrior
{
    public enum Type { Level1, Level2, Level3 }
    [Serializable]
    class Enemy : SpaceShip
    {
        public Type type;
        public int Level { get; set; }

        public Enemy(Point center, Type type, Bitmap sprite)
        {
            base.center = center;
            base.Hitbox.X = base.center.X;
            base.Hitbox.Y = base.center.Y;
            this.type = type;

            switch (type)
            {
                case Type.Level1:
                    base.Sprite = sprite;
                    base.Lives = 1;
                    base.Width = 80;
                    base.Height = 80;
                    base.Speed = 3;
                    this.Level = 1;
                    break;

                case Type.Level2:
                    base.Sprite = sprite;
                    base.Lives = 2;
                    base.Width = sprite.Width;
                    base.Height = sprite.Height;
                    base.Speed = 2;
                    this.Level = 2;
                    break;

                case Type.Level3:
                    base.Sprite = sprite;
                    base.Lives = 3;
                    base.Width = sprite.Width;
                    base.Height = sprite.Width;
                    base.Speed = 1;
                    this.Level = 3;
                    break;
            }

            base.Hitbox.Width = base.Width;
            base.Hitbox.Height = base.Height;
        }

        public void Move(bool Direction)
        {

            if (Direction)
            {
                base.center = new Point(center.X + base.Speed, center.Y );
                base.Hitbox.X = base.center.X;
            }
            else
            {
                base.center = new Point(center.X - base.Speed, center.Y);
                base.Hitbox.X = base.center.X;
            }

        }

    }
}
