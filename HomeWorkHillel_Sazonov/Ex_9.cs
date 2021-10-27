using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkHillel_Sazonov
{
    class Ex_9
    {
        public void Ex9()
        {
            Console.WriteLine("Ex9");
            string a = Console.ReadLine();
            string[] str = a.Split(new char[] { ' ', ':', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string[] str2 = new string[5];
            str2[0] = str[0];
            if (int.Parse(str[1]) == 1)
            {
                str2[1] = "Jan";
            }
            if (int.Parse(str[1]) == 2)
            {
                str2[1] = "Feb";
            }
            if (int.Parse(str[1]) == 3)
            {
                str2[1] = "Mar";
            }
            if (int.Parse(str[1]) == 4)
            {
                str2[1] = "Apr";
            }
            if (int.Parse(str[1]) == 5)
            {
                str2[1] = "May";
            }
            if (int.Parse(str[1]) == 6)
            {
                str2[1] = "Jun";
            }
            if (int.Parse(str[1]) == 7)
            {
                str2[1] = "Jul";
            }
            if (int.Parse(str[1]) == 8)
            {
                str2[1] = "Aug";
            }
            if (int.Parse(str[1]) == 9)
            {
                str2[1] = "Sem";
            }
            if (int.Parse(str[1]) == 10)
            {
                str2[1] = "Oct";
            }
            if (int.Parse(str[1]) == 11)
            {
                str2[1] = "Nov";
            }
            if (int.Parse(str[1]) == 12)
            {
                str2[1] = "Dec";
            }
            //
            if (int.Parse(str[3]) > 12)
            {
                str2[2] = (int.Parse(str[3]) - 12).ToString();
                str2[4] = "PM";
            }
            else
            {
                str2[2] = str[3];
                str2[4] = "AM";
            }
            str2[3] = str[4];
            Console.WriteLine(str2[0] + " " + str2[1] + ", " + str2[2] + ":" + str2[3] + " " + str2[4]);
        }
    }
}
