using System;
using AutoMapper;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs.Category;

namespace MiniShop.Business.Mappings
{
	public class GeneralMappingProfile : Profile
	{
		public GeneralMappingProfile()
		{
			CreateMap<Category, CategoryDTO>().ReverseMap();
		}
	}
}

