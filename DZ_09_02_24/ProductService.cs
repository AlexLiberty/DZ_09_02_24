using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_09_02_24
{
    public class ProductService : IProductService
    {
        private readonly ApplicationContext context;

        public ProductService(ApplicationContext context)
        {
            this.context = context;
        }

        public void AddProduct(Product product)
        {
                context.Products.Add(product);
                context.SaveChanges();       
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = context.Products.FirstOrDefault(p => p.Id == id);
            if (productToDelete != null)
            {
                context.Products.Remove(productToDelete);
                context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Товар не знайдено");
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                throw new InvalidOperationException("Товар не знайдено");
            }

            context.Entry(existingProduct).Property("Timestamp").OriginalValue = product.Timestamp;

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.AvailableQuantity = product.AvailableQuantity;

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = ex.Entries.Single();
                var databaseValues = entry.GetDatabaseValues();
                if (databaseValues == null)
                {
                    throw new InvalidOperationException("Дані товару було видалено іншим користувачем");
                }
                else
                {
                    var databaseProduct = (Product)databaseValues.ToObject();
                    throw new InvalidOperationException("Дані товару було змінено іншим користувачем.");
                }
            }
        }

    }
}
