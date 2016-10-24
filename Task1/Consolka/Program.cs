using System;
using Task1Library;
using System.Text;
using System.IO;
using System.Reflection;
using System.Collections;

namespace Consolka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("По завершению ввода строк введите: end");
            StringBuilder SB = new StringBuilder();
            //StringBuilder userEnter = new StringBuilder();
            //while(true)
            //{
            //    userEnter.Append(Console.ReadLine());
            //    if (userEnter.ToString()=="end")
            //    {
            //        break;
            //    }
            //    SB.AppendLine(userEnter.ToString());

            //    userEnter.Clear();
            //}

            RegexKoordinaty k = new RegexKoordinaty(SB.ToString());

            ///путь к экзэшнику
            Assembly asm = Assembly.GetExecutingAssembly();
            string assemblyPath = new Uri(asm.EscapedCodeBase).LocalPath;
            ///путь к текстовому файлу
            k.Pathfile = Path.Combine(Path.GetDirectoryName(assemblyPath), "12.txt");
            
            try
            {
                string NewText = k.AllUserTextNewFormat();
                Console.WriteLine(NewText);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message + e.FileName);
            }
            
            try
            {
                string message = k.CountBadLines();
                Console.WriteLine(message);
            }

            catch (FormatException)
            {
                Console.WriteLine("ВАЖНО!!! Не все строки имели правильный формат");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("ошибка к доступу файла");
            }
            Console.ReadLine();
        }
    }
}
