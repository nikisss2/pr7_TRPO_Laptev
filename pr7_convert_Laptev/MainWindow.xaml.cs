using System.Windows;
using pr7_convert_Laptev.Models;

namespace pr7_convert_Laptev
{
    public partial class MainWindow : Window
    {
        public CarRental Rental { get; set; }

        public MainWindow()
        {
            Rental = new CarRental();

            InitializeComponent();
            DataContext = Rental;
        }
    }
}
