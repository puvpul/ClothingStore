using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClothingStore.Api.Models;

namespace ClothingStore.Api.Data
{
    public interface ICatalougeRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Category> Categories { get; }
        Task<int> SaveProductAsync(Product product);
        Task<Product> DeleteProductAsync(int productID);
    }
}