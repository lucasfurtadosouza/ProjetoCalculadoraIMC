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
using System.Windows.Shapes;

namespace Aula_1
{
    /// <summary>
    /// Lógica interna para CalculadoraWindow.xaml
    /// </summary>
    public partial class CalculadoraWindow : Window
    {
        public CalculadoraWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;   
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtPeso.Focus();
        }
        bool maximize = false;

        private void btFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string msg = "";
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                double imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    msg = "Abaixo do Peso.";
                }
                else
                {
                    if ((imc >= 18.5) && (imc <= 24.5))
                    {
                        msg = "Peso Ideal, Parabéns!!.";
                    }
                    else
                    {
                        if ((imc >= 25) && (imc <= 29.9))
                        {
                            msg = "Sobrepeso.";
                        }
                        else
                        {
                            if ((imc >= 30) && (imc <= 34.9))
                            {
                                msg = "Obesidade Grau I.";
                            }
                            else
                            {
                                if ((imc >= 35) && (imc <= 39.9))
                                {
                                    msg = "Obesidade Grau II.";
                                }
                                else
                                {
                                    if (imc >= 40)
                                    {
                                        msg = "Obesidade Grau III (Mórbita).";
                                    }
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Seu IMC é de: " + imc + " e a sua classificação é de: " + msg, "IMC", MessageBoxButton.OK, MessageBoxImage.Information);
                txtPeso.Clear();
                txtAltura.Clear();
                txtPeso.Focus();
            }
            catch
            {
                MessageBox.Show("Caracteres Inválidos, Tente Novamente", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPeso.Clear();
                txtAltura.Clear();
                txtPeso.Focus();
            }
        }
    }
}
