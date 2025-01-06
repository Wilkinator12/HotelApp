using HotelAppLibrary.Models;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for CheckInWindowHomework.xaml
    /// </summary>
    public partial class CheckInWindowHomework : Window
    {
        public BookingFullModel Booking { get; }



        public CheckInWindowHomework(BookingFullModel booking)
        {
            InitializeComponent();
            Booking = booking;

            DataContext = Booking;
        }



    }
}
