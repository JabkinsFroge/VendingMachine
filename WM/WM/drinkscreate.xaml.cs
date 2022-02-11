using Microsoft.Win32;
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
using System.IO;
using System.Windows.Navigation;

namespace WM
{
    /// <summary>
    /// Логика взаимодействия для drinkscreate.xaml
    /// </summary>
    public partial class drinkscreate : Window
    {
        public drinkscreate()
        {
            InitializeComponent();
        }

        private void savepic_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf *.jpeg";
            //var pickture;

            if (openDialog.ShowDialog() == true)
            {
                //var pickture = Convert.ToByte(System.IO.Path.GetFileName(openDialog.FileName));
                //var pickture = File.ReadAllBytes(openDialog.FileName);
                //Image.Source = pickture;
                //Image.Source = new BitmapImage(new Uri(openDialog.FileName));

                Kartinka.Text = System.IO.Path.GetFileName(openDialog.FileName);
                Image.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }
    }
}
