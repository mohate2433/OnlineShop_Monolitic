using OnlineShop_Mvp.Models.DomainModels.OrderAggregates;

namespace OnlineShop_Mvp.Models.DomainModels.ProductAggregate
{
    public class Product
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string? Title { get; set; }
        public int UnitPrice { get; set; }
        public string? ProductDescription { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public bool IsRemoved { get; set; } = false;
        public string? PictureTitle { get; internal set; }
        public string? PictureAddress { get; internal set; }
        public string? PictureAlt { get; internal set; }
    }
}
