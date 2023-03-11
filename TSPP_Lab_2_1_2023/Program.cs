//TSPP_Lab_2_1_2023 Виведення назви мiсяця за його порядковим номером
using System;

namespace TSPP_Lab_2_1_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N;
            do
            {
                Console.Write("\n Введiть номер мiсяця вiд 1 до 12 цифрою:  ");
                string T = Console.ReadLine();
                N = uint.Parse(T);
                string Rez;
                switch (N)
                {
                    case 1: Rez = "\n Ви обрали перший мiсяць року i це сiчень!"; break;
                    case 2: Rez = "\n Ви обрали другий мiсяць року i це грудень!"; break;
                    case 3: Rez = "\n Ви обрали третiй мiсяць року i це березень!"; break;
                    case 4: Rez = "\n Ви обрали четвертий мiсяць року i це квiтень!"; break;
                    case 5: Rez = "\n Ви обрали пя'тий мiсяць року i це травень!"; break;
                    case 6: Rez = "\n Ви обрали шостий мiсяць року i це червень!"; break;
                    case 7: Rez = "\n Ви обрали сьомий мiсяць року i це липень!"; break;
                    case 8: Rez = "\n Ви обрали восьмий мiсяць року i це серпень!"; break;
                    case 9: Rez = "\n Ви обрали дев'ятий мiсяць року i це вересень!"; break;
                    case 10: Rez = "\n Ви обрали десятий мiсяць року i це жовтень!"; break;
                    case 11: Rez = "\n Ви обрали одинадцятий мiсяць року i це листопад!"; break;
                    case 12: Rez = "\n Ви обрали дванадцятий мiсяць року i це грудень!"; break;
                    default: Rez = "\n Введено некоректне число! Повторiть введення."; break;
                }
                Console.Clear();
                Console.WriteLine(Rez);
            }
            while (N < 1 || N > 12);

            Console.ReadLine();

        }
    }
}
