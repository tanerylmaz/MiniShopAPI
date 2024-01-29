using System;
using AutoMapper;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs.Category;
using MiniShop.Shared.DTOs.Product;

namespace MiniShop.Business.Mappings
{
	public class GeneralMappingProfile : Profile
	{
		public GeneralMappingProfile()
		{
            CreateMap<Category, AddCategoryDTO>().ReverseMap();

            CreateMap<Product, ProductDTO>().ReverseMap();
			CreateMap<Category, CategoryDTO>()
				.ForMember(cdto=>cdto.ProductList,options=>
				options.MapFrom(c=>c.ProductCategories.Select(pc=>pc.Product)))
				.ReverseMap();
		}
	}
}

