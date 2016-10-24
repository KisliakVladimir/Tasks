using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System;

namespace Task1Library
{
    /// <summary>
    /// Класс принимает текст и построчно ищет координаты формата "**.****,**.****" 
    /// переделывая их формат "X: **.****, Y: **.****" 
    /// если они соответствуют шаблону, если нет то считаем флаг и в Exception указываем сколько неверных форматов
    /// </summary>
    public class RegexKoordinaty
    {
        /// <value>
        /// Свойство UserText хранит пользовательский текст, который нужно будет отформатировать.
        /// </value>
        public string UserText { get; set; }
        /// <value>
        /// Свойство Pattern хранит Пользоваетльский Pattern, по которому будет форматироваться текст из UserText.
        /// Если это свойство не заполнено, то используется стандартный шаблон "([0-9]{2}[.][0-9]{4})[,]([0-9]{2}[.][0-9]{4})"
        /// который делает из 11.1111,22.2222 вот такой X: 11.1111, Y: 22.2222
        /// </value>
        public string Pattern { get; set; }
        /// <summary>
        /// Свойство хранит путь к файлу с которого будем считывать строки. Если свойство не заполнено, то обрабатываем
        /// текст из Свойства UserText, а не из файла
        /// </summary>
        public string Pathfile { get; set; }
        /// <summary>
        /// Конструктор с одним параметром, принимает текст от пользователя
        /// Внутри конструктор также устанавливает Свойству Pattern значение по умолчанию
        /// "([0-9]{2}[.][0-9]{4})[,]([0-9]{2}[.][0-9]{4})"
        /// </summary>
        /// <param name="userText">Передается через Set свойству UserText</param>
        public RegexKoordinaty (string userText)
        {
            this.UserText = userText;
            this.Pattern = "([0-9]{2}[.][0-9]{4})[,]([0-9]{2}[.][0-9]{4})";
        }
        /// <summary>
        /// 2-ой конструктор с двумя параметрами задающими свойства UserText и Pattern
        /// </summary>
        /// <param name="userText">Передается в Свойство UserText</param>
        /// <param name="pattern">Передается в Свойство Pattern</param>
        public RegexKoordinaty(string userText, string pattern)
        {
            this.UserText = userText;
            this.Pattern = pattern;
        }
        /// <summary>
        /// Метод обрабатывает пользовательский текст из свойства UserText и с помощью регулярного выражения
        /// шаблона Pattern заменяет все вхождения 23.8976,12.3218 на X: 23,8976 Y: 12,3218.
        /// Метод имеет две ветви в первой проверяет свойство Pathfile на null, если это так то обрабатывается
        /// текст не из файла, а из свойства UserText. Если же Pathfile заполнено, то проверяем существует ли указанный файл.
        /// Если не существует кидаем наверх FileNotFindExceptionю
        /// </summary>
        /// <returns> newText новый текст с отформатированными строками</returns>
        public string AllUserTextNewFormat()
        {
            
            if (Pathfile != null)
           {
                if (File.Exists(Pathfile))
                {
                    string text;
                    using (StreamReader str = new StreamReader(Pathfile))
                    {
                        
                        text = str.ReadToEnd();
                    }
                    UserText = null;
                    UserText = text;
                }
                else
                {
                    throw new FileNotFoundException("файл не найден либо указан неверный путь", "123.txt");
                }
                
            }
            /// <remarks>
            /// создает шаблон для проверки каждой строки
            /// </remarks>
            string replacement = "X: $1 Y: $2";
            string newText = Regex.Replace(UserText, Pattern, replacement);
            return newText;
        }
        /// <summary>
        /// Метод построчно обрабатывает пользовательский текст и если он строка не соответсвует шаблону делаем
        /// ++countNotMatch, и сохраняем номера строк с неправильным форматом. По окончанию обработки, если countNotMatch>0
        /// генерируем наверх FormatException с количеством неправильных строк.
        /// </summary>
        /// <returns>если countNotMatch>0 генерируем наверх FormatException с количеством неправильных строк.
        /// Если нет то возвращаем ""</returns>
        public string CountBadLines()
        {
          
            if (Pathfile!=null && !File.Exists(Pathfile))
            {
                throw new FileNotFoundException("Файл не существует либо указан неверный путь");
                 
            }
            int countNotMatch=0;
            int countLines=0;
            StringBuilder sb = new StringBuilder();
            Regex regx = new Regex(Pattern);

            string[] kb = UserText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                   for (int i =0; i<kb.Length; i++)
            {
                if (!regx.IsMatch(kb[i].ToString()))
                {
                    ++countNotMatch;
                    sb.AppendLine("неправильный формат в строке №" + (1+countLines));
                }
                ++countLines;
            }
                   if (countNotMatch>0)
            {
                FormatException exF = new FormatException(countNotMatch + " строк имели неправильный формат. Вводите правильный формат везде");
                return sb.ToString();
                throw exF;
            }
                
               return sb.ToString();
            }
        }

   

    }

