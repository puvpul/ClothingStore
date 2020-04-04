using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ClothingStore.Api.Models;

namespace ClothingStore.Api.Data
{
    public class OrderRepository : IOrderRepository
    {
        private ClothingStoreDbContext context = new ClothingStoreDbContext();
        public IEnumerable<Order> Orders
        {
            get
            {
                return context.Orders.Include("Lines").Include("Lines.Product");
            }
        }
        public async Task<int> SaveOrderAsync(Order order)
        {
            if (order.OrderId==0)
            {
                context.Orders.Add(order);
            }
            return await context.SaveChangesAsync();
        }
        public async Task<Order> DeleteOrderAsync(int orderID)
        {
            Order dbOrder = context.Orders.Find(orderID);
            if (dbOrder !=null)
            {
                context.Orders.Remove(dbOrder);
            }
            await context.SaveChangesAsync();
            return dbOrder;
        }

        
    }
}