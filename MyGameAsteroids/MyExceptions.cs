using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Drawing;
/// <summary>
/// /Уровень_2.Урок_2.Задание_5: * Создать собственное исключение GameObjectException,
///     которое появляется при попытке  создать объект с неправильными характеристиками
///     (например, отрицательные размеры, слишком большая скорость или неверная позиция).
/// </summary>
namespace MyGameAsteroids
{
    public class MyExceptions
    {
        public class GameObjectException : Exception
        {
            public GameObjectException()
            {
            }
            //исключение выхода за границы игрового поля объектом
            public GameObjectException(Point pos, Type type) : base ($"Обект {type.Name} ({pos.X},{pos.Y}) вышел за границы игрвого поля")
            {

            }

            public GameObjectException(string message, Exception innerException) : base(message, innerException)
            {
                
            }

            protected GameObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
