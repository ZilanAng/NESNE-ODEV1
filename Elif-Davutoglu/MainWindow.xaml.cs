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

namespace Elif_Davutoglu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            urun ur = new urun();
            ur.ShowDialog();
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


    }
}
