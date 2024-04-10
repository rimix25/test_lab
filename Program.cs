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
        string quetion = "n";
        Console.WriteLine("Проект разработал Романов ИМ");
        Console.WriteLine("Добро пожаловать в калькулятор. Вам необходимо ввести первое число, затем знак действия(+,-,*,/), которое хотите совершить и второе число.");

            while(quetion == "n")
        {
            float one, two, result;
            char sign;
            
            Console.Write("Введите первое число: ");
            one = CheckNum();
            Console.Write("Введите знак действия : ");
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
            
            Console.WriteLine("Завершить работу программу (y / n)?");
            quetion = Console.ReadLine();

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
