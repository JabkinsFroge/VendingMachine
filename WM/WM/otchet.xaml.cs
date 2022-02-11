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

namespace WM
{
    /// <summary>
    /// Логика взаимодействия для otchet.xaml
    /// </summary>
    public partial class otchet : Page
    {
        public otchet()
        {
            InitializeComponent();
            VendingMachinesEntities database = new VendingMachinesEntities();
            table.ItemsSource = database.Drinks.ToList();
        }
        VendingMachinesEntities database = new VendingMachinesEntities();

    }
}
