using OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderDeatailDtos;
using OnlineShop_Mvp.Services.Dtos.PersonDtos;

namespace OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderHeaderDtos
{
    public class OrderHeader_Save_Dto
    {

        public Guid SellerID { get; set; }
        public Guid BuyerID { get; set; }
        public List<OrderDetail_Detail_Dto>? orderDetail_Detail_Dtos { get; set; }
        public List<Person_Save_Dto>? PersonDtos { get; set; }
        public Person_Detail_Dto? Seller { get; set; }
        public Person_Detail_Dto? Buyer { get; set; }
    }
}
