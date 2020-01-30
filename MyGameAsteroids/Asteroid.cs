using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using MyGameAsteroids.Properties;

namespace MyGameAsteroids
{
    class Asteroid : BaseObject
    {
        private Image _image = Resources.asteroid;
        public int Power { set; get; }
        public Asteroid(Point pos, Point dir, Size size, Pen pen) : base(pos, dir, size, pen)
        {
            Power = 1;
            if (pos.X > Game.Width || pos.X < 0) throw new MyExceptions.GameObjectException(pos, this.GetType());
            
        }
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
        /// <summary>
        /// Уровень_2.Урок_2.Задание_3: Сделать так, чтобы при столкновении пули с астероидом они регенерировались в разных концах экрана.
        /// </summary>
        /// <param размер окна приложения в ширину="width"></param>
        /// <param размер окна приложения в выосту="height"></param>
        public void Resurrection(int width, int height = 0)
        {
            Pos.X = width - 1;
            Pos.Y = height;
        }
    }
}
