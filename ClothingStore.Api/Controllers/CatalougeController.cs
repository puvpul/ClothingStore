using ClothingStore.Api.Data;
using ClothingStore.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ClothingStore.Api.Controllers
{
    public class CatalougeController : ApiController
    {
        //implementing ninject DI
        private ICatalougeRepository Repository { get; set; }
        public CatalougeController(ICatalougeRepository catRepoImpl)
        {
            Repository = catRepoImpl;
        }
        public IEnumerable<Product> GetProducts()
        {
            return Repository.Products;
        }
        public Product GetProduct(int id)
        {
            return Repository.Products.Where(p => p.Id == id).FirstOrDefault();
        }
        public IEnumerable<Category> GetCategories()
        {
            return Repository.Categories;
        }
        public async Task PostProduct(Product product)
        {
            await Repository.SaveProductAsync(product);
        }
        public async Task DeleteProduct(int productId)
        {
            await Repository.DeleteProductAsync(productId);
        }
    }
}
