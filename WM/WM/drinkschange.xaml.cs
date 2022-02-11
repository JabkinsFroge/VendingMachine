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
    /// Логика взаимодействия для drinkschange.xaml
    /// </summary>
    public partial class drinkschange : Window
    {
        public drinkschange(string name, int coust, int count, int id)
        {
            InitializeComponent();
            VendingMachinesEntities database = new VendingMachinesEntities();
            Nazvanie.Text = name;
            Tsena.Text = Convert.ToString(coust);
            Kolvo.Text = Convert.ToString(count);
            ID.Content = id;
        }


        VendingMachinesEntities database = new VendingMachinesEntities();

        private void save_Click(object sender, RoutedEventArgs e)
        {
            int check = Convert.ToInt32(ID.Content);
            var drinks = database.Drinks.Where(c => c.Id == check).FirstOrDefault();
            var drinks1 = database.VendingMachineDrinks.Where(c => c.DrinksId == check).FirstOrDefault();
            drinks.Name = Nazvanie.Text;
            drinks1.Count = Convert.ToInt32(Kolvo.Text);
            drinks.Cost = Convert.ToInt32(Tsena.Text);
            database.SaveChanges();
            otchet otchet = new otchet();

            int id = Convert.ToInt32(ID.Content);
            int count = drinks1.Count;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void savepic_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
