using OnlineShop.Services.Dtos.OrdersDtos.OrderHeaderDtos;
using OnlineShop_Mvp.Services.Dtos.OrdersDtos.OrderHeaderDtos;
using OnlineShop_Mvp.Services.Dtos.PersonDtos;

namespace OnlineShop_Mvp.Services.Contracts
{
    public interface IOrderHeaderService
    {
        List<OrderHeader_FillGrid_Dto> FillGrid();
        List<Person_FillGrid_Dto> PersonFillGrid();
        void Save(OrderHeader_Save_Dto orderHeader_Save_Dto);
        OrderHeader_Edit_Dto FindEdit(Guid id);
        OrderHeader_Detail_Dto Find(Guid id);
        void Edit(OrderHeader_Edit_Dto orderHeader_Edit_Dto);
        void Delete(Guid id);
    }
}
