using Microsoft.EntityFrameworkCore;
using OnlineShop_Mvp.Models;
using OnlineShop_Mvp.Models.DomainModels.OrderAggregates;
using OnlineShop_Mvp.Models.Services.Contracts;

namespace OnlineShop_Mvp.Models.Services.Repositories
{
    public class OrderHeaderRepository : IOrderHeaderRepository
    {
        private readonly OnlineShopDbContext _context;

        public OrderHeaderRepository(OnlineShopDbContext context)
        {
            _context = context;
        }

        public void AddOrderHeader(OrderHeader orderHeader)
        {
            using (_context)
            {
                try
                {
                    _context.OrderHeader.Add(orderHeader);
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    _context.Dispose();
                }
            }
        }


        public List<OrderHeader> GetOrderHeaders()
        {
            using (_context)
            {
                try
                {
                    return _context.OrderHeader.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    _context.Dispose();
                }
            }
        }


        public void UpdateOrderHeader(OrderHeader orderHeader)
        {
            using (_context)
            {
                try
                {
                    _context.Entry(orderHeader).State = EntityState.Modified;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    _context.Dispose();
                }
            }
        }

        public void DeleteOrderHeader(Guid id)
        {
            using (_context)
            {
                try
                {
                    var orderHeader = GetOrderHeader(id);
                    _context.Entry(orderHeader).State = EntityState.Deleted;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    _context.Dispose();
                }
            }
        }

        public OrderHeader GetOrderHeader(Guid Id)
        {
            using (_context)
            {
                try
                {
                    return _context.OrderHeader.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    _context.Dispose();
                }
            }
        }
    }
}
