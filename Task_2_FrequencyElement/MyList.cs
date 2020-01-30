using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Шагов Александр Уровень_2.Урок_4.Задание_2:
 * Дана коллекция List<T>. Требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции:
    а) для целых чисел;
   *б) для обобщенной коллекции;
  **в) используя Linq.
 */
namespace Task_2_FrequencyElement
{
    /// <summary>
    /// Обобщенный класс с обобщеном списком
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyList<T>
    {
        List<T> _lst_1;
        Dictionary<T, int> dict;
        public MyList(List<T> unknownList)
        {
            _lst_1 = unknownList;
            dict = new Dictionary<T, int>();
        }
        public void PrintFrequencyTList(ListBox listBox)
        {

                foreach(var KeyValue in _lst_1)
                {
                    try
                    {
                        dict[KeyValue]++;
                    }catch
                    {
                        dict[KeyValue] = 1;
                    }
                }
            listBox.Items.Add("===================С помощью Обобщенного списка================");
            AddToListBox(listBox, dict);
        }
        #region **В) С использованием linQ 
        public void PrintFrequencyWithLinq(ListBox listBox)
        {
            var res = _lst_1.Select(s => s).GroupBy(el => el).ToDictionary(g => g.Key, g => g.Count());
            listBox.Items.Add("===================С помощью LinQ===============================");
            AddToListBox(listBox, res);
        }
        #endregion
        #region Метод заполнения лист бокса
        private void AddToListBox(ListBox listBox, Dictionary<T, int> dict)
        {
            foreach (var KeyValue in dict)
            {
                listBox.Items.Add($"Элемент {KeyValue.Key} содержиться {KeyValue.Value} раз");
            }
            listBox.Items.Add($"================================================================");
        }
        #endregion
    }
}
