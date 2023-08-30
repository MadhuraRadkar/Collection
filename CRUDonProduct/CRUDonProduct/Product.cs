using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDonProduct
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }
    }
    public class ProductCRUD
    {
        private List<Product> productlist;
        public ProductCRUD()
        {
            productlist = new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop", Price = 35000, Company = "HP" },
                new Product { Id = 2, Name = "Laptop", Price = 37000, Company = "Dell" }
            };
        }
        public List<Product> GetProducts()  // Display List...
        {
            return productlist;
        }
        public Product GetProductByID(int id)  // get single product....
        {
            // Search for id in the collection.
            Product product = new Product();
            foreach (Product p in productlist)
            {
                if (p.Id == id)
                {
                    product = p;
                    break;
                }
            }
            return product;
        }
        public void AddProduct(Product p)  // Add new Product....
        {
            productlist.Add(p);
        }
        public void UpdateProduct(Product p) // Modify the product.... p contains new data.
        {
            foreach (Product item in productlist)
            {
                // item contains old product data.
                if(item.Id== p.Id)
                {
                    item.Name= p.Name;
                    item.Price= p.Price;
                    item.Company= p.Company;
                    break;
                }
            } 
        }
        public void DeleteProduct(int id)  // Remove  Product....
        {
            foreach (Product item in productlist)
            {
                if(item.Id== id)
                {
                    productlist.Remove(item);
                    break;
                }
            }
        }
        

    }
}
