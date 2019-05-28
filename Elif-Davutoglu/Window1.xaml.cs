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
using System.Windows.Shapes;

namespace Elif_Davutoglu
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            uyelik uye = new uyelik();
            uye.ShowDialog();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            sepet sep = new sepet();
            sep.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            urun ur = new urun();
            ur.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Hide();
        }
    }
}
