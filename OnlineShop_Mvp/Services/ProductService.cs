using OnlineShop_Mvp.Models.DomainModels.ProductAggregate;
using OnlineShop_Mvp.Models.Services.Contracts;
using OnlineShop_Mvp.Services.Contracts;
using OnlineShop_Mvp.Services.Dtos.ProductDtos;

namespace OnlineShop_Mvp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        private static List<Product_FillGrid_Dto> Convert(List<Product> products)
        {
            var dtoList = new List<Product_FillGrid_Dto>();
            for (int i = 0; i < products.Count; i++)
            {
                dtoList.Add(new Product_FillGrid_Dto());
                dtoList[i].Id = products[i].Id;
                dtoList[i].Title = products[i].Title;
                dtoList[i].Code = products[i].Code;
                dtoList[i].UnitPrice = products[i].UnitPrice;
                dtoList[i].ProductDescription = products[i].ProductDescription;
                dtoList[i].PictureAddress = products[i].PictureAddress;
                dtoList[i].PictureAlt = products[i].PictureAlt;
                dtoList[i].PictureTitle = products[i].PictureTitle;
            }
            return dtoList;
        }
        private static Product Convert(Product_Save_Dto product_Save_Dto)
        {
            var product = new Product()
            {
                Id = new Guid(),
                Title = product_Save_Dto.Title,
                Code = product_Save_Dto.Code,
                UnitPrice = product_Save_Dto.UnitPrice,
                ProductDescription = product_Save_Dto.ProductDescription,
                PictureAddress = product_Save_Dto.PictureAddress,
                PictureAlt = product_Save_Dto.PictureAlt,
                PictureTitle = product_Save_Dto.PictureTitle
            };
            return product;
        }
        private static Product_Edit_Dto ConvertEdit(Product product)
        {
            var Product_Edit_Dto = new Product_Edit_Dto()
            {
                Title = product.Title,
                Id = product.Id,
                Code = product.Code,
                ProductDescription = product.ProductDescription,
                UnitPrice = product.UnitPrice,
                PictureAlt = product.PictureAlt,
                PictureAddress = product.PictureAddress,
                PictureTitle = product.PictureTitle

            };
            return Product_Edit_Dto;
        }
        private static Product_Detail_Dto Convert(Product product)
        {
            var product_Detail_Dto = new Product_Detail_Dto()
            {
                Title = product.Title,
                Id = product.Id,
                Code = product.Code,
                ProductDescription = product.ProductDescription,
                UnitPrice = product.UnitPrice,
                PictureAlt = product.PictureAlt,
                PictureAddress = product.PictureAddress,
                PictureTitle = product.PictureTitle
            };
            return product_Detail_Dto;
        }
        private static Product Convert(Product_Edit_Dto product_Edit_Dto)
        {
            var product = new Product()
            {
                Id = product_Edit_Dto.Id,
                Title = product_Edit_Dto.Title,
                Code = product_Edit_Dto.Code,
                UnitPrice = product_Edit_Dto.UnitPrice,
                ProductDescription = product_Edit_Dto.ProductDescription,
                PictureAddress = product_Edit_Dto.PictureAddress,
                PictureAlt = product_Edit_Dto.PictureAlt,
                PictureTitle = product_Edit_Dto.PictureTitle
            };
            return product;
        }

        public void Delete(Guid id) => _productRepository.DeleteProduct(id);

        public void Edit(Product_Edit_Dto product_Edit_Dto) => _productRepository.UpdateProduct(Convert(product_Edit_Dto));

        public List<Product_FillGrid_Dto> FillGrid() => Convert(_productRepository.GetProducts());

        public void Save(Product_Save_Dto product_Save_Dto) => _productRepository.AddProduct(Convert(product_Save_Dto));

        public Product_Detail_Dto Find(Guid id) => Convert(_productRepository.GetProduct(id));

        public Product_Edit_Dto FindEdit(Guid id) => ConvertEdit(_productRepository.GetProduct(id));
    }
}
