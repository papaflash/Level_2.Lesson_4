using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_FrequencyElement
{
    public partial class Form1 : Form
    {
        const int _count = 20;
        List<string> _lstStr = new List<string>();
        List <int> _lstInt = new List<int>();
        Random random = new Random();
        MyList<String> _myListStr;
        //MyList<int> _myListInt;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetElements_Click(object sender, EventArgs e)
        {
            _myListStr?.PrintFrequencyTList(listElements);
            //_myListInt?.PrintFrequencyTList(listElements);
            _myListStr?.PrintFrequencyWithLinq(listElements);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < _count; i++)
            {
                _lstStr.Add($"Name{random.Next(1, 20)}");
                _lstInt.Add(random.Next(1, 15));
            }
            _myListStr = new MyList<string>(_lstStr);
            //_myListInt = new MyList<int>(_lstInt);
        }
    }
}
