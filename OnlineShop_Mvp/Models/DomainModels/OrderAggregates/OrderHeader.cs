using OnlineShop_Mvp.Models.DomainModels.PersonAggregates;

namespace OnlineShop_Mvp.Models.DomainModels.OrderAggregates
{
    public class OrderHeader
    {
        public Guid ID { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public Person? Seller { get; set; }
        public Person? Buyer { get; set; }
        public Guid SellerID { get; set; }
        public Guid BuyerID { get; set; }
    }
}
