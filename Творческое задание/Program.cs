using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Творческое_задание
{
    enum Workers
    {
        начальство, 
        системщик, 
        разработчик
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание с работниками");
            Console.WriteLine("Все работники");
            Person semen = new Person("Семён", Workers.начальство);
            Person rashid = new Person("Рашид", Workers.начальство, semen);
            Person lucas = new Person("Лукас", Workers.начальство, rashid);
            Person alkham = new Person("Ольхам", Workers.начальство, semen);
            Person orkady = new Person("Оркадий", Workers.начальство, alkham);
            Person volodya = new Person("Володя", Workers.начальство, alkham);
            Person iltash = new Person("Ильташ", Workers.начальство, volodya);
            Person ivanich = new Person("Иваныч", Workers.начальство, iltash);
            Person ilya = new Person("Илья", Workers.системщик, ivanich);
            Person vitya = new Person("Витя", Workers.системщик, ivanich);
            Person zhenya = new Person("Женя", Workers.системщик, ivanich);
            Person sergey = new Person("Сергей", Workers.начальство, volodya);
            Person laysan = new Person("Ляйсан", Workers.начальство, sergey);
            Person marat = new Person("Марат", Workers.разработчик, laysan);
            Person dina = new Person("Дина", Workers.разработчик, laysan);
            Person anton = new Person("Ильдар", Workers.разработчик, laysan);
            Person ildar = new Person("Антон", Workers.разработчик, laysan);

            Task task_1 = new Task("Дать задания рабочим", Workers.начальство);
            Task task_2 = new Task("Посчитать прибыль", Workers.начальство);
            Task task_3 = new Task("Настроить сеть", Workers.системщик);
            Task task_4 = new Task("Разработать приложение", Workers.разработчик);

            Console.WriteLine("Выберите кому будет дана задача"+
                "\nДля того чтобы Иваныч дал Илье задание, нажмите 0 " + 
                "\nДля того чтобы Иваныч дал Вите задание, нажмите 1" + 
                "\nДля того чтобы Иваныч дал Жене задание, нажмите 2" +
                "\nДля того чтобы Ляйсан дал Марату задание, нажмите 3" +
                "\nДля того чтобы Ляйсан дал Дине задание, нажмите 4" + 
                "\nДля того чтобы Ляйсан дал Ильдару задание, нажмите 5" +
                "\nДля того чтобы Ляйсан дал Антону задание, нажмите 6" + 
                "\nДля того чтобы Володя лад Сергею задание, нажмите 7" + 
                "\nДля того чтобы Оркадий дал Сергею задание, нажмите 8" +
                "\nДля того чтобы Семен дал Ольхаму задание, нажмите 9" + 
                "\nДля того чтобы, Семен дал Марату задание, нажмите 10" + 
                "\nДля того чтобы Володя дал Дине задание, нажмите 11");
            bool flag = uint.TryParse(Console.ReadLine(), out uint number);
            if (flag)
            {
                switch (number)
                {
                    case 0:
                        ilya.ExecutionofaTask(task_3, ivanich);
                        break;
                    case 1:
                        vitya.ExecutionofaTask(task_3, ivanich);
                        break;
                    case 2:
                        zhenya.ExecutionofaTask(task_3, ivanich);
                        break;
                    case 3:
                        marat.ExecutionofaTask(task_4, laysan);
                        break;
                    case 4:
                        dina.ExecutionofaTask(task_4, laysan);
                        break;
                    case 5:
                        ildar.ExecutionofaTask(task_4, laysan);
                        break;
                    case 6:
                        anton.ExecutionofaTask(task_4, laysan);
                    break;
                    case 7:
                        sergey.ExecutionofaTask(task_1, volodya);
                        break;
                    case 8:
                        sergey.ExecutionofaTask(task_1, orkady);
                        break;
                    case 9:
                        alkham.ExecutionofaTask(task_1, semen);
                        break;
                    case 10:
                        marat.ExecutionofaTask(task_4, semen);
                        break;
                    case 11:
                        dina.ExecutionofaTask(task_4, volodya);
                        break;
                    default:
                        Console.WriteLine("Вы написали число, которое не входит в промежуток");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Нельзя писать строки или символы");
            }
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
            
            


        }
    }
}
