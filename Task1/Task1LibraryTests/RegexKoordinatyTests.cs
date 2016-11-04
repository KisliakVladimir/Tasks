using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Task1Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1Library.Tests
{
    [TestClass()]
    public class RegexKoordinatyTests
    {

        [TestMethod()]
        public void RegexKoordinatyPropertyUserText_Data_Data()
        {
            var k = new RegexKoordinaty("11.1111,55.6666");
            var usertext = k.UserText;
            var NewText = "11.1111,55.6666";
            Assert.AreEqual(NewText, usertext);
        }
        [TestMethod()]
        public void RegexKoordinatyPropertyPattern_Data_Data()
        {
            var k = new RegexKoordinaty("11.1111,55.6666", "([0-9]{2}[.][0-9]{4})[,]([0-9]{2}[.][0-9]{4})");
            var pattern = k.Pattern;
            Assert.AreEqual(pattern, "([0-9]{2}[.][0-9]{4})[,]([0-9]{2}[.][0-9]{4})");
        }
        [TestMethod()]
        public void AllUserTextNewFormat_Data_ShouldFormatData()
        {
            var k = new RegexKoordinaty("11.1111,55.6666");
            var usertext = k.AllUserTextNewFormat();
            var NewText = "X: 11.1111 Y: 55.6666";
            Assert.AreEqual(NewText, usertext);
        }

        [TestMethod()]
        public void AllUserTextNewFormat_Datafromfile_ShouldFormatData()
        {
            var k = new RegexKoordinaty("11.1111,55.6666");
            k.Pathfile = @"d:\ASP\ASP\Task1\Consolka\bin\Release\123.txt";
            var usertext = k.AllUserTextNewFormat();
            var NewText = "X: 45.8888 Y: 65.9989\r\nX: 33.8595 Y: 66.6595\r\nX: 88.3658 Y: 95.8595\r\nX: 11.5555 Y: 65.6958\r\n";
            Assert.AreEqual(NewText, usertext);
        }

        [TestMethod()]
        public void AllUserTextNewFormat_File_Not_Find_Exception()
        {
            var k = new RegexKoordinaty("11.1111, 55.6666");
            k.Pathfile = @"d:\ASP\ASP\Task1\Consolka\bin\Release\13.txt";
            try
            {
                var ExceptionText = k.AllUserTextNewFormat();
            }
            catch (FileNotFoundException e)
            {
                StringAssert.Contains(e.Message, "файл не найден либо указан неверный путь");
            }

        }
        [TestMethod()]
        public void CountBadLinesTest_GoodFormat_NotReturn()
        {
            var k = new RegexKoordinaty("11.1111,55.6666");
            var usertext = k.CountBadLines();
            var NewText = "";
            Assert.AreEqual(NewText, usertext);
        }
        [TestMethod()]
        public void CountBadLines_FileNotExist_Exception()
        {
            var k = new RegexKoordinaty("11.1111, 55.6666");
            k.Pathfile = @"d:\ASP\ASP\Task1\Consolka\bin\Release\13.txt";
            try
            {
                var ExceptionText = k.CountBadLines();
            }
            catch(FileNotFoundException e)
            {
                StringAssert.Contains(e.Message, "Файл не существует либо указан неверный путь");
            }
            
        }

        [TestMethod()]
        public void CountBadLines_BadFormat_Exception()
        {
            var k = new RegexKoordinaty("11.1111, 55.6666");
            
            try
            {
                var ExceptionText = k.CountBadLines();
            }
            catch (FormatException e)
            {
                StringAssert.Contains(e.Message, "1 строк имели неправильный формат. Вводите правильный формат везде");
            }

        }
    }
}