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

namespace Calendar_Black_Out_Assignment
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

        // Instantiate Two Date Time Variable

        public DateTime myFirstDate, mySecondDate;

       


        // Get First Date

        public void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            myFirstDate = myCalendar.SelectedDate.Value;
        
        } 

        // Get Second Date

        public void mySecondCalendar_SelectedDatesChanged(object sender, SelectedCellsChangedEventArgs e)
        {

            mySecondDate = mySecondCalendar.SelectedDate.Value;

        }

        // Call Black Out Method

        private void button_Click(object sender, RoutedEventArgs e)
        {

            SetBlackOutDates(myFirstDate, mySecondDate);

        }

        private void SetBlackOutDates(DateTime myFirstDate, DateTime mySecondDate)
        {
            blackOutCalendar.BlackoutDates.Add(new CalendarDateRange(myFirstDate, mySecondDate));
        }
    }
   
}
