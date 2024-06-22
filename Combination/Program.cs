using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите комбинацию: ");
            int buff, buff2, buff3, num = 3, num2 = 6, num3 = 8, i = 0, count1 = 0, count2;
            do
            {
                count1 = 0;
                count2 = 0;
                Console.Write("Первая цифра: ");
                buff = Convert.ToInt32(Console.ReadLine());
                Console.Write("Вторая цифра: ");
                buff2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Третья цифра: ");
                buff3 = Convert.ToInt32(Console.ReadLine());
                if (buff == num || (buff == num2 && buff != buff2) || (buff == num3 && buff != buff3)) count1++;
                if (buff2 == num2 || (buff2 == num && buff2 != buff) || (buff2 == num3 && buff2 != buff3)) count1++;
                if (buff3 == num3 || (buff3 == num && buff3 != buff) || (buff3 == num2 && buff3 != buff2)) count1++;
                if (buff == buff2 && num == num2 || buff2 == buff3 && num2 == num3 || buff == buff3 && num == num3) count1--;
                if (buff == num) count2++;
                if (buff2 == num2) count2++;
                if (buff3 == num3) count2++;
                if (count2 > count1) count1 = count2;
                if (count1 == 3 || count1 == 2) Console.WriteLine("Вы угадали {0} цифры", count1);
                else if (count1 == 1) Console.WriteLine("Вы угадали 1 цифру");
                else Console.WriteLine("Вы не угадали ни одной цифры");
                if (count2 == 3 || count2 == 2) Console.WriteLine("На своих позициях находится {0} цифры", count2);
                else if (count2 == 1) Console.WriteLine("На своих позициях находится 1 цифра");
                else Console.WriteLine("На своих позициях не находится ни одна цифра");
                i++;
                Console.WriteLine("Количество попыток: " + i);
            }
            while (buff != num || buff2 != num2 || buff3 != num3);
            Console.WriteLine("Вы угадали комбинацию. Нажмите любую клавишу для выхода из программы.");
            Console.ReadKey();
        }
    }
}
