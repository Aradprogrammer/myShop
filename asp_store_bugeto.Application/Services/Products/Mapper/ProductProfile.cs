using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asp_store_bugeto.Application.Services.Products.Queries.GetProductForAdmin;
using asp_store_bugeto.Application.Services.Products.Queries.GetProducts;
using asp_store_bugeto.Domain.Entities.Products;
using AutoMapper;

namespace asp_store_bugeto.Application.Services.Products.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductForAdminDtoForList>()
                .ForMember(dest => dest.FirstImg, ope => ope.MapFrom(src => src.ProductImages.Count > 0 ? src.ProductImages.First().Src : "#"))
                .ForMember(dest => dest.CategoryName, ope => ope.MapFrom(src => $"{src.Category.ParentCategory.Name} - {src.Category.Name}"));



            CreateMap<Product, ProductDtoForList>()
                .ForMember(dest => dest.FirstImg, ope => ope.MapFrom(src => src.ProductImages.Count > 0 ? src.ProductImages.First().Src : "#"))
                .ForMember(dest => dest.CategoryName, ope => ope.MapFrom(src => $"{src.Category.ParentCategory.Name} - {src.Category.Name}"));

            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Images, ope => ope.MapFrom(src => src.ProductImages))
                .ForMember(dest => dest.Featurs, ope => ope.MapFrom(src => src.ProductFeature))
                .ForMember(dest => dest.Category, ope => ope.MapFrom(src => $"{src.Category.ParentCategory.Name} - {src.Category.Name}"))
                .ForMember(dest => dest.CategoryId, ope => ope.MapFrom(src => src.Category.Id));

            CreateMap<ProductFeatures, FeatursProduct>();
            CreateMap<ProductImages, ImagesProduct>();
        }
    }
}
