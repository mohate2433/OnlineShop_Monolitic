using OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderDeatailDtos;
using OnlineShop_Mvp.Services.Dtos.PersonDtos;

namespace OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderHeaderDtos
{
    public class OrderHeader_FillGrid_Dto
    {
        public Guid ID { get; set; }
        public Guid SellerID { get; set; }
        public Guid BuyerID { get; set; }
        public List<OrderDetail_FillGrid_Dto>? OrderDetail_FillGrid_Dtos { get; set; }
        public IEnumerable<Person_FillGrid_Dto>? person_FillGrid_Dtos { get; set; }
        public Person_FillGrid_Dto? Seller { get; set; }
        public Person_FillGrid_Dto? Buyer { get; set; }

    }
}
