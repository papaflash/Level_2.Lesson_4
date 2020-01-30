using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Resources;
/* Уровень_2.Урок_3.Задание 3: Добавить аптечки
 */

namespace MyGameAsteroids
{
    class MedicineChest : BaseObject
    {
        private Image _image = Properties.Resources.FirstAidKit;
        public int HealPower { set; get; } = 10;
        public MedicineChest(Point pos, Point dir, Size size, Pen pen) : base(pos, dir, size, pen) { }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_image, Pos.X, Pos.Y, Size.Width, Size.Height);
        }
        public override void Update()
        {
            Pos.X += Dir.X;
            Pos.Y += Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
        }

    }
}
