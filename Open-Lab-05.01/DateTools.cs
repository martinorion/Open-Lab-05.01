using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
              int a;
            if (year % 100 == 0)
            {
                a = year / 100;
            }
            else
            {
                a = year / 100 + 1;
            }

            string b = a.ToString();

           // alternatíva int a = year % 100 == 0 ? year / 100 : year / 100 + 1;

           
            if(a == 11 || a == 12)
            {
                return b + "th century";
            }
            if (b.ToCharArray()[b.Length - 1] == '1')
            {
                return b + "st century";
            }
            if (b.ToCharArray()[b.Length - 1] == '2')
                {
                return b + "nd century";
            }
            if (b.ToCharArray()[b.Length - 1] == '3')
            {
                return b + "rd century";
            }

            return b + "th century";
        }
    }
}
