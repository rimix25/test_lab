using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calc;

public class Program
{
    private static void Main()
    {
      
            float one, two, result;
            char sign;
            Console.WriteLine("Добро пожаловать в калькулятор. Вам нелбходимо ввести первое число, затем знак действия(+,-,*,/), которое хотите совершить и второе число.");
            Console.Write("Введите первое число: ");
            one = CheckNum();
            Console.Write("Введите знак действия : ");
            sign = CheckSym();
            Console.Write("Введите Второе число: ");
            two = CheckNum();
        if (sign == '+')
            {
                result = one + two;
                Console.WriteLine("Сумма ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '-')
            {
                result = one - two;
                Console.WriteLine("Разность ваших чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '*')
            {
                result = one * two;
                Console.WriteLine("Произведение ваших чисел равно " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '/')
            {
                
                if(two == 0) 
                {
                throw new DivideByZeroException("На ноль делить нельзя");
                }
            try { 
                result = one / two;
                    Console.WriteLine("Частное ваших чисел равна " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            catch(DivideByZeroException ex) { 
                Console.WriteLine(ex.Message);
            }
                
                

            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();


            }

        

        

    }

    public static float CheckNum()
    {
        while (true)
        {
            string text = Console.ReadLine();
            if(float.TryParse(text, out float result))
            {
                return result;
                break;
            }
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
        }
    }  
     
    public static char CheckSym()
    {
        while (true)
        {
            //char allsym[] = {("+", "-", "*", "/"};
            string [] allsym = {"+", "-", "*", "/"};
            string sym = Convert.ToString(Console.ReadLine());
            if(allsym.Contains(sym)){
                return Convert.ToChar(sym);
                break;
            }
            Console.WriteLine("Не верный знак");
        }
        
        
    }
}
