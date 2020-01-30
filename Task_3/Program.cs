using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Шагов Александр Уровень_2.Урок_4.Задача_3:
 *Дан фрагмент программы:
Dictionary<string, int> dict = new Dictionary<string, int>()
  {
    {"four",4 },
    {"two",2 },
    { "one",1 },
    {"three",3 },
  };
     var d = dict.OrderBy(delegate(KeyValuePair<string,int> pair) { return pair.Value; });
     foreach (var pair in d)
    {
      Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
    }

а. Свернуть обращение к OrderBy с использованием лямбда-выражения =>.
b. * Развернуть обращение к OrderBy с использованием делегата . - Не понял, что нужно сделать.
 */
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four",4 },
                {"two",2 },
                { "one",1 },
                {"three",3 },
            };
            var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });
            //Свернул к лямбда выражению
            var res = dict.OrderBy(g => g.Value);
                    
            foreach (var pair in d)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
            Console.WriteLine("============================");
            foreach (var keyValue in res)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }
            Console.ReadKey();
        }

    }
}
