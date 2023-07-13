using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
    internal class MyConsole
    {
        private string[] _vowel = { "а", "у", "о", "ы", "и", "э", "я", "ю", "ё", "е" };
        private StringBuilder _sb = new StringBuilder();

        public void ChangeTheNameOfApp (string userInput)
        {
            foreach (var item in _vowel)
            {
                if (item == userInput)
                {                     
                    _sb.Append(userInput);
                    Console.Title = _sb.ToString();
                }
            }            
        }
        public MyConsole()
        {
        }
    }
}
