using System;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using Task1Library;

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TextRange pp = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            RegexKoordinaty k = new RegexKoordinaty(pp.Text);
            if (new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text.Length > 3)
            {
              
                FlowDocument myflow = new FlowDocument();
                string newtext = k.AllUserTextNewFormat();
                myflow.Blocks.Add(new Paragraph(new Run(newtext)));
                richTextBox1.Document = myflow;

                string warning = "";
                FlowDocument myflow1 = new FlowDocument();

                try
                {
                    warning = k.CountBadLines();
                }
                catch (FormatException)
                {


                }
                finally
                {
                    myflow1.Blocks.Add(new Paragraph(new Run(warning)));
                    richTextBox2.Document = myflow1;
                }
            }
               if(textBox.Text.Length>2)
            {
                k.Pathfile = textBox.Text;
                string newtext1 = "";
                try
                {
                    newtext1 = k.AllUserTextNewFormat();
                }
                catch (FileNotFoundException exf)
                {
                    FlowDocument myflow4 = new FlowDocument();
                    myflow4.Blocks.Add(new Paragraph(new Run(exf.Message)));
                    richTextBox2.Document = myflow4;
                }
                FlowDocument myflow2 = new FlowDocument();
                myflow2.Blocks.Add(new Paragraph(new Run(newtext1)));
                richTextBox1.Document = myflow2;

                string warning1 = "";
                FlowDocument myflow3 = new FlowDocument();

                try
                {
                    warning1 = k.CountBadLines();
                }
                catch (FormatException)
                {


                }
                finally
                {
                    myflow3.Blocks.Add(new Paragraph(new Run(warning1)));
                    richTextBox2.Document = myflow3;
                }
            }
              
               

            
        }
    }
}
