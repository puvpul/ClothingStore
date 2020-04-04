using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ClothingStore.Api.Models;

namespace ClothingStore.Api.Data
{
    public class CatalougeRepository : ICatalougeRepository
    {
        private ClothingStoreDbContext context = new ClothingStoreDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
        public IEnumerable<Category> Categories
        {
            get { return context.Categories; }
        }
        public async Task<Product> DeleteProductAsync(int productID)
        {
            Product dbProduct = context.Products.Find(productID);
            if (dbProduct != null)
            {
                context.Products.Remove(dbProduct);
            }
            await context.SaveChangesAsync();
            return dbProduct;
        }

        public async Task<int> SaveProductAsync(Product product)
        {
            if (product.ProductId == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbProduct = context.Products.Find(product.ProductId);
                if (dbProduct !=null)
                {
                    dbProduct.Name = product.Name;
                    dbProduct.Description = product.Description;
                    dbProduct.Price = product.Price;
                    dbProduct.CategoryId = product.CategoryId;
                }
            }
            return await context.SaveChangesAsync();
        }
        public async Task<int> SaveCategoriesAsync(Category category)
        {
            if (category.CategoryId == 0)
                context.Categories.Add(category);
            else
            {
                Category dbCategory = context.Categories.Find(category.CategoryId);
                if (dbCategory != null)
                {
                    dbCategory.Name = category.Name;
                    dbCategory.Description = category.Description;
                }
                {

                }
            }
            {

            }
            return await context.SaveChangesAsync();
        }
    }
}