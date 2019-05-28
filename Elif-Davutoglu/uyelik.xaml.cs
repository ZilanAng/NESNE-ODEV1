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
    /// Interaction logic for uyelik.xaml
    /// </summary>
    public partial class uyelik : Window
    {
        public uyelik()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (text_email.Text != "" && text_sifre.Text != "")
                MessageBox.Show("Giriş Başarılı","Giriş",MessageBoxButton.OK,MessageBoxImage.Information);
            else
                MessageBox.Show("Lütfen gerekli alanları doldurunuz", "Giriş", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (text_ad.Text != "" && text_soyad.Text != "" && text_email2.Text != "" && text_sifre2.Text != "" && text_sifretekrar.Text != "")
                MessageBox.Show("Kayıt Başarılı", "Giriş", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Lütfen gerekli alanları doldurunuz", "Giriş", MessageBoxButton.OK, MessageBoxImage.Warning);

        }
    }
}
