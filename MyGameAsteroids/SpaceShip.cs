using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyGameAsteroids.Properties;

//Добавил свой класс корабль

namespace MyGameAsteroids
{
    class SpaceShip: BaseObject
    {
        public static event Message MessageDie;
        public static event MessageJournal Message;
        private int _energy = 100;
        public int Eneregy {
            set { _energy = value; } get => _energy; }
        private Image _image = Resources.cb;
        public SpaceShip(Point pos, Point dir, Size size, Pen pen) : base(pos, dir, size, pen)
        {

        }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_image, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        public override void Update()
        {
        }
        public void Up()
        {
            if (Pos.Y > 0) Pos.Y -= Dir.Y;
            Message?.Invoke("Нажата клавиша вверх");
        }
        public void Down()
        {
            if (Pos.Y < Game.Height) Pos.Y += Dir.Y;
            Message?.Invoke("Нажата клавиша вниз");
        }
        public void EnergyLow(int n)
        {
            _energy -= n;
            Message?.Invoke($"Корабль получает урон: {n} здоровье: {_energy}");
        }
        public void EnergyUp(int n)
        {
            _energy += n;
            Message?.Invoke($"Корабль получает получает атечку: {n} здоровье: {_energy}");
        }
        public void Die() 
        {
            MessageDie?.Invoke();
        }
    }
}
