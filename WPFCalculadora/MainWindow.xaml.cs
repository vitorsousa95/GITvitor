using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool AutoPlay { get; set; }
        double acumula = 0;
        string operacao = "";
        private MediaPlayer mediaplayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void sete_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void um_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void dois_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void tres_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void quatro_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void cinco_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void seis_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void oito_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void nove_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\quack.mp3"));
            mediaplayer.Play();
        }

        private void soma_Click(object sender, RoutedEventArgs e)
        {

            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "+";
            }
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();
        }

        private void igual_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\acertou-mizeravijk.mp3"));
            mediaplayer.Play();
        }

        private void virgula_Click(object sender, RoutedEventArgs e)
        {
            display.Text += ",";
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();
        }

        private void subtracao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();
        }

        private void multiplicacao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "*";
            }
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();
        }

        private void divisao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "/";
            }
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();
        }

        private void voltar_Click(object sender, RoutedEventArgs e)
        {
            int x = display.Text.Length - 1;
            if (x >= 0)
            {
                display.Text = display.Text.Substring(0, x);
            }
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();
        }

        private void inverso_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double d = double.Parse(display.Text);
                if (d == 0)
                {
                    display.Text = "Dividindo por zero!!!";
                }
                else
                {
                    d = 1 / d;
                    display.Text = d.ToString();
                }
            }
            catch (Exception Ex)
            {

                for (int i = 0; i < 100000; i++)
                {
                    display.Text = "Para com isso pisicopata. ";
                    // em espera.
                }
                display.Text = "";

            }
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();
        }

        private void raiz_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(display.Text);
            if (x < 0)
            {
                display.Text = "Este valor não é valido.";
            }
            else
            {
                x = Math.Sqrt(x);
                display.Text = x.ToString();
            }
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            acumula = 0;
            display.Text = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            operacao = "";
        }

        private void maisoumenos_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(display.Text) * (-1);
            display.Text = x.ToString();
            mediaplayer.Open(new Uri(@"C:\Users\hbsis\Downloads\wow_8.mp3"));
            mediaplayer.Play();
        }
    }
}
