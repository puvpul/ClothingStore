using System;
using System.Threading.Tasks;
using ClothingStore.Api.Models;
using System.Collections.Generic;

namespace ClothingStore.Api.Data
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        Task<int> SaveOrderAsync(Order order);
        Task<Order> DeleteOrderAsync(int orderID);
    }
}
