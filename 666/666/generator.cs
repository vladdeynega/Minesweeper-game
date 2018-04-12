using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _666
{
    class generator
    {
        public int[,] field;
        int N;
       

        public void init(int n)
        {
            N = n;
            field = new int[n, n];
        }

        public void plantMines(int k)
        {
            Random rand = new Random();
      
            for (int i = 0; i < k; i++)
            {   
                    field[rand.Next(0, field.GetLength(0)), rand.Next(0, field.GetLength(1))] = 1;
            }

        }

        public void calculate()
        {

        }

    }
}
