using OnlineShop_Mvp.Models.DomainModels.OrderAggregates;

namespace OnlineShop_Mvp.Models.Services.Contracts
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDeatails();
        void AddOrderDeatail(OrderDetail orderDetail);
        void UpdateOrderDeatail(OrderDetail orderDetail);
        void DeleteOrderDeatail(Guid productId, Guid orderHeaderId);
        OrderDetail GetOrderDeatail(Guid productId, Guid orderHeaderId);
    }
}
