using OnlineShop_Mvp.Models.DomainModels.ProductAggregate;

namespace OnlineShop_Mvp.Models.DomainModels.OrderAggregates
{
    public class OrderDetail
    {
        public Guid ProductID { get; set; }
        public Guid OrderHeaderID { get; set; }
        public Product? Product { get; set; }
        public OrderHeader? OrderHeader { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

    }
}
