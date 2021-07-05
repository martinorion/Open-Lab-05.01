using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
             int x;
            if(year % 100 == 0)
            {
                x = year / 100;
            }
            else
            {
                x = year/100 + 1;
            }

            string y = x.ToString();
            return y;
        }
    }
}
