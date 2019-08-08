using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAutenticacaDeCadastro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool seTelefoneValido = false;
        bool seEmalValido = false;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (seEmalValido && seTelefoneValido == true)
                MessageBox.Show("Dados Salvos");
            else
                MessageBox.Show("Verifique seu dados primeiro");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Regex telefone = new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");

            if (telefone.IsMatch(CampoTelefone.Text))
            {
                MessageBox.Show("Telefone Valido!");
                seTelefoneValido = true;
            }

            else
            {
                MessageBox.Show("Telefone Invalido!");
                seTelefoneValido = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Regex email = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (email.IsMatch(CampoEmail.Text))
            {
                MessageBox.Show("E-mail Valido!");
                seEmalValido = true;
            }

            else
            {
                MessageBox.Show("E-mail Invalido!");
                seEmalValido = false;
            }
               
        }
    }
}
