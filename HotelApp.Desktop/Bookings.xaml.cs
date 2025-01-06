using HotelAppLibrary.Data;
using HotelAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelApp.Desktop
{
    /// <summary>
    /// Interaction logic for Bookings.xaml
    /// </summary>
    public partial class Bookings : Window
    {
        private readonly IDatabaseData _db;

        public ObservableCollection<BookingFullModel> BookingsList { get; set; } = new ObservableCollection<BookingFullModel>();



        public Bookings(IDatabaseData db)
        {
            InitializeComponent(); 

            DataContext = this;

            _db = db;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            BookingsList.Clear();

            var bookingsList = _db.SearchBookings(lastNameTextBox.Text);

            foreach (var item in bookingsList)
            {
                BookingsList.Add(item);
            }
        }
    }
}
