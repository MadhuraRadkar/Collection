using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Collection.Interface2Non;

namespace Collection
{
    public class Interface2Non
    {            // IComparable.
        public class Product:IComparable
        {
            private int Price;
            private string Name;
            public Product(int Price, string Name)
            {
                this.Price = Price;
                this.Name = Name;
            }
            public int CompareTo(object obj)
            {
                // Convert object to product class.
                Product p = (Product)obj;// p hold info of pencil.
                                         // this-->pen,p-->pencil.
                if (this.Price > p.Price)
                {
                    return 1;
                }
                else if (this.Price < p.Price)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
            public override string ToString()
            {
                return $"{Name}-->{Price}";
            }
        }
        static void Main(string[] args)
        {
            Product pen = new Product(20, "Pen");
            Product pencil = new Product(10, "Pencil");
            int result = pen.CompareTo(pencil);
            if (result == 1)
            {
                Console.WriteLine("Price of pen is more than pencil");

            }
            else if (result == -1)
            {
                Console.WriteLine("Price of pen is less than pencil");
            }
            else
            {
                Console.WriteLine("Pen $ pencil has same price");
            }

        }
    }
}
