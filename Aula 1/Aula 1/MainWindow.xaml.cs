using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Aula_1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        //Aluno: Lucas Furtado Souza       Turma: 3°B 
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtUsuario.Focus();
        }
        bool maximize = false;

        private void btFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
        private void btMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btMaximizar_Click(object sender, RoutedEventArgs e)
        {
            if (maximize == false)
            {
                WindowState = WindowState.Maximized;
                maximize = true;
            }
            else
            {
                WindowState = WindowState.Normal;
                maximize = false;
            }
        }

        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Password.ToString();

            if ((usuario == "joao") && (senha == "123"))
            {
                var window = new CalculadoraWindow();
                window.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login ou Senha Inválidos, Tente Novamente", "Erro" ,MessageBoxButton.OK, MessageBoxImage.Error);
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }

        }
    }
}
