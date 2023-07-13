using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var myConsole = new MyConsole();
            Console.Title = "";
            var userInput = "";
            MenuEnum menuChoice = MenuEnum.None;
            while (menuChoice != MenuEnum.CloseApp)
            {
                Console.Clear();
                Console.WriteLine("Добрый день!" + Environment.NewLine +
                "Задача данного приложения обрабатывать вводимые пользователем символы. Вы можете ввести любые символы по одному, однако учитываться будут только буквы. Если вводится гласная буква - ввод принимается. Если согласная - отклоняется. " +
                Environment.NewLine + "Каждая введенная гласная будет изменять название консольного приложения. Приступим?");
                Console.WriteLine("1. Ввести символ" + Environment.NewLine +
                "2. Закончить работу");

                Console.WriteLine("Выберете пункт меню:");
                menuChoice = (MenuEnum)Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
                {
                    case MenuEnum.ReadTheLine:
                        Console.Clear();
                        Console.WriteLine("Введите символ");
                        userInput = Console.ReadLine().ToLower();
                        if (userInput.Length > 1)
                        {
                            Console.WriteLine("Необходимо ввести один символ русского алфавита. Вы будете возвращены в меню.");
                            Console.ReadKey();
                        }
                        else
                        {
                            myConsole.ChangeTheNameOfApp(userInput);
                        }
                        break;
                    case MenuEnum.CloseApp:
                        break;
                    default:
                        Console.WriteLine("Выберете пункт меню");
                        Console.Clear();
                        break;
                }
            }
        }
    }
} 
