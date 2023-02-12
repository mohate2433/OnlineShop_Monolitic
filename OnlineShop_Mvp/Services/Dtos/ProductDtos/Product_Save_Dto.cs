namespace OnlineShop_Mvp.Services.Dtos.ProductDtos
{
    public class Product_Save_Dto
    {

        public int Code { get; set; }
        public string? Title { get; set; }
        public int UnitPrice { get; set; }
        public string? PictureAddress { get; set; }
        public string? PictureAlt { get; set; }
        public string? PictureTitle { get; set; }
        public string? ProductDescription { get; set; }
    }
}
