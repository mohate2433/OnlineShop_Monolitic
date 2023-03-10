using OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderDeatailDtos;
using OnlineShop_Mvp.Services.Dtos.PersonDtos;

namespace OnlineShop.Services.Dtos.OrdersDtos.OrderHeaderDtos
{
    public class OrderHeader_Edit_Dto
    {
        public Guid ID { get; set; }
        public Guid SellerID { get; set; }
        public Guid BuyerID { get; set; }
        public List<OrderDetail_Edit_Dto>? OrderDetail { get; set; }
        public Person_Edit_Dto? Seller { get; set; }
        public Person_Edit_Dto? Buyer { get; set; }
    }
}
