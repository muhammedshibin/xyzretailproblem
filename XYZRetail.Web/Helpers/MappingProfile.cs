using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XYZRetail.Core.Dtos;
using XYZRetail.Core.Entities;

namespace XYZRetail.Web.Helpers
{
    public class MappingProfile : Profile
    {
       

        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryName, src => src.MapFrom(opt => opt.Category.CategoryName));

            CreateMap<Basket, BasketResponseDto>()
                .ForMember(dest => dest.CustomerName, src => src.MapFrom(opt => opt.Customer.CustomerName))
                .ForMember(dest => dest.Email, src => src.MapFrom(opt => opt.Customer.EmailAddress))
                .ForMember(dest => dest.Address, src => src.MapFrom(opt => opt.Customer.Address));

            CreateMap<BasketItem, ItemInBasketDto>();

        }
    }
}
