using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkHillel_Sazonov
{
    class Ex_11
    {
        public void Ex11()
        {
            Console.WriteLine("Ex11");
            Random rnd = new Random();



            List<ArrayList> d = new List<ArrayList>();
            for (int i = 0; i < 10; i++)
            {
                ArrayList s = new ArrayList();
                s.Add("a");
                s.Add(rnd.Next(0, 10));
                d.Add(s);
            }
            foreach (ArrayList i in d)
            {
                Console.WriteLine(i[0] + " " + i[1]);

            }
            for (int i = 0; i < d.Count; i++)
            {
                for (int j = 0; j < d.Count; j++)
                {
                    if ((int)d[i][1] == (int)d[j][1] && i != j)
                    {
                        d.Remove(d[i]);
                    }
                }
            }

            Console.WriteLine();
            foreach (ArrayList i in d)
            {
                Console.WriteLine(i[0] + " " + i[1]);
            }
        }
    }
}
