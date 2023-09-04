using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class Matrix3By3
    {   // 3. Create a Matrix of 3 * 3 and calculate addition and display details.
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            List<int> result = new List<int>();
            for(int i=0;i<3;i++)
            {
                int sum = 0;
                for(int j=0;j<3;j++)
                {
                    sum = sum + matrix[i,j];
                }
                result.Add(sum);
            }
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            
              
          
        }
    }
}