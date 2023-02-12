using Microsoft.EntityFrameworkCore;
using OnlineShop_Mvp.Models;
using OnlineShop_Mvp.Models.DomainModels.OrderAggregates;
using OnlineShop_Mvp.Models.Services.Contracts;

namespace OnlineShop_Mvp.Models.Services.Repositories
{
    public class OrderDeatailRepository : IOrderDetailRepository
    {
        private readonly OnlineShopDbContext _context;

        public OrderDeatailRepository(OnlineShopDbContext context)
        {
            _context = context;
        }

        public void AddOrderDeatail(OrderDetail orderDetail)
        {
            using (_context)
            {
                try
                {
                    _context.OrderDetail.Add(orderDetail);
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

        public void DeleteOrderDeatail(Guid productId, Guid orderHeaderId)
        {
            using (_context)
            {
                try
                {
                    var orderDetail = GetOrderDeatail(productId, orderHeaderId);
                    _context.Entry(orderDetail).State = EntityState.Deleted;
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

        public OrderDetail GetOrderDeatail(Guid productId, Guid orderHeaderId)
        {
            using (_context)
            {
                try
                {
                    return _context.OrderDetail.Find(productId, orderHeaderId);
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

        public List<OrderDetail> GetOrderDeatails()
        {
            using (_context)
            {
                try
                {
                    return _context.OrderDetail.ToList();
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



        public void UpdateOrderDeatail(OrderDetail orderDetail)
        {
            using (_context)
            {
                try
                {
                    _context.Entry(orderDetail).State = EntityState.Modified;
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
