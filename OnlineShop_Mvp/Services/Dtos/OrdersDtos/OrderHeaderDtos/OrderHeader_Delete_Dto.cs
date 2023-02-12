using OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderDeatailDtos;
using OnlineShop_Mvp.Services.Dtos.PersonDtos;

namespace OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderHeaderDtos
{
    public class OrderHeader_Delete_Dto
    {

        public Guid SellerID { get; set; }
        public Guid BuyerID { get; set; }
        public List<OrderDetail_Delete_Dto>? OrderDetail_Delete_Dto { get; set; }
        public Perosn_Delete_Dto? Seller { get; set; }
        public Perosn_Delete_Dto? Buyer { get; set; }
    }
}
