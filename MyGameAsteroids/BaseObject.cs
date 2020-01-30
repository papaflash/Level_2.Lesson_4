using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGameAsteroids
{
    public delegate void Message();
    public delegate void MessageJournal(string s); //делегат для ведения журнала
    abstract class BaseObject: ICollision
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;
        protected Pen MyPen;
        

        protected BaseObject(Point pos, Point dir, Size size, Pen myPen)
        {
             
            Pos = pos;
            Dir = dir;
            Size = size;
            MyPen = myPen;
        }

        public Rectangle Rect => new Rectangle(Pos, Size);

        public bool Collision(ICollision obj) => obj.Rect.IntersectsWith(this.Rect);

        public abstract void Draw();
        /// <summary>
        /// Уровень_2.Урок_2.Задание_2: Переделать виртуальный метод Update в BaseObject в абстрактный и реализовать его в наследниках.
        /// </summary>
        public abstract void Update();
    }
}
