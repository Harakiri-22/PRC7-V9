using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PRC7_V9
{
    class Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        public static bool TimeCompare(int hour, int minute, int second, int hour1, int minute1, int second1)
        {
            bool result = hour == hour1 && minute == minute1 && second == second1;
            return result;
        }

        public int Hour
        {
            get => _hour;

            set
            {
                if (value % 2 == 1 && value < 24)
                {
                    _hour = value;
                }
                else
                {
                    MessageBox.Show("Ошибка, введены не корректные данные");
                }
            }
        }

        public int Minute
        {
            get => _minute;

            set
            {
                if (value % 2 == 1 && value < 60)
                {
                    _minute = value;
                }
                else
                {
                    MessageBox.Show("Ошибка, введены не корректные данные");
                }
            }
        }

        public int Second
        {
            get => _second;

            set
            {
                if (value % 2 == 1 && value < 60)
                {
                    _second = value;
                }
                else
                {
                    MessageBox.Show("Ошибка, введены не корректные данные");
                }
            }
        }
    }
}
