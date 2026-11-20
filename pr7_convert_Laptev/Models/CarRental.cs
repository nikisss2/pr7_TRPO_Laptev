using System.ComponentModel;

namespace pr7_convert_Laptev.Models
{
    public class CarRental : INotifyPropertyChanged
    {
        private string carModel = "";
        private double dailyPrice;
        private int days = 1;
        private double discount;

        public string CarModel
        {
            get { return carModel; }
            set
            {
                carModel = value;
                OnPropertyChanged("CarModel");
            }
        }

        public double DailyPrice
        {
            get { return dailyPrice; }
            set
            {
                dailyPrice = value;
                OnPropertyChanged("DailyPrice");
                OnPropertyChanged("InitialCost");
                OnPropertyChanged("RentalCost");
            }
        }

        public int Days
        {
            get { return days; }
            set
            {
                days = value;
                OnPropertyChanged("Days");
                OnPropertyChanged("InitialCost");
                OnPropertyChanged("RentalCost");
            }
        }

        public double Discount
        {
            get { return discount; }
            set
            {
                discount = value;
                OnPropertyChanged("Discount");
                OnPropertyChanged("RentalCost");
            }
        }

        public double InitialCost
        {
            get
            {
                return dailyPrice * days;
            }
        }

        public double RentalCost
        {
            get
            {
                double total = dailyPrice * days;
                double discountSum = total * discount;
                return total - discountSum;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
