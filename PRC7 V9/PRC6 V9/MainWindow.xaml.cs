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

namespace PRC7_V9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Мишин Д.А. ИСП-34", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CompareTime_Click(object sender, RoutedEventArgs e)
        {
            Time timeOne = new Time
            {
                Hour = Convert.ToInt32(hour1.Text),
                Minute = Convert.ToInt32(minute1.Text),
                Second = Convert.ToInt32(second1.Text)
            };

            Time timeTwo = new Time
            {
                Hour = Convert.ToInt32(hour2.Text),
                Minute = Convert.ToInt32(minute2.Text),
                Second = Convert.ToInt32(second2.Text)
            };

            bool result;
            result = Time.TimeCompare(timeOne.Hour, timeOne.Minute, timeOne.Second, timeTwo.Hour, timeTwo.Minute, timeTwo.Second);

            if (result == true)
            {
                MessageBox.Show("Моменты времени равны");
            }
            else
            {
                MessageBox.Show("Моменты времени неравны");
            }
        }
    }
}
