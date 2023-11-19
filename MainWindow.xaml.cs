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

namespace RecursionIter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var tabul = new Tabul();
                tabul.GetList(Convert.ToDouble(start.Text), Convert.ToDouble(end.Text), Convert.ToDouble(step.Text));

                Box.Items.Clear();
                foreach (var point in tabul.Res.ToArray())                
                    Box.Items.Add("X = " + point.X + "\t Mathematics: " + point.Math + "\t Iteration: " + point.Iter +
                        "\t Recursion: " + point.Rec);
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
