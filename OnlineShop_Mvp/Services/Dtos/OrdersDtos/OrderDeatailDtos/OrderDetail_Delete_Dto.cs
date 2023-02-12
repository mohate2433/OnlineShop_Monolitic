using OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderHeaderDtos;
using OnlineShop_Mvp.Services.Dtos.ProductDtos;

namespace OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderDeatailDtos
{
    public class OrderDetail_Delete_Dto
    {
        public Product_Delete_Dto? Product_Delete_Dto { get; set; }
        public OrderHeader_Delete_Dto? OrderHeader_Delete_Dto { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
