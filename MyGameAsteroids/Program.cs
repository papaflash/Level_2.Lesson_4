using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Шагов Александр. Уровень_2.Урок_3.Задание: Добавить ведение журнала в консоль в виде делегата
 */

namespace MyGameAsteroids
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Form form = new Form();
            //добавил лист бокс на форму для ведния лога.
            ListBox logBox = new ListBox();
            logBox.Name = "logBox";
            logBox.Location = new System.Drawing.Point(0, 600);
            logBox.Size = new System.Drawing.Size(1280, 80);
            
            form.Controls.Add(logBox);
            form.Width = 1280;
            form.Height = 720;
            //{
            //    Width = Screen.PrimaryScreen.Bounds.Width,
            //    Height = Screen.PrimaryScreen.Bounds.Height
            //};
            Game.Init(form, logBox);
            form.Show();
            Game.Draw();
            Application.Run(form);
            form.FormClosing += Form_FormClosing;
        }

        private static void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Game.sw.Close();
        }
    }
}
