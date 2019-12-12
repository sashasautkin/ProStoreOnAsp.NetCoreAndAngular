using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Dto;
using WebApiProStore.Models;

namespace WebApiProStore.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<ShoppingBag, ShoppingBagDto>();
            CreateMap<ShoppingBagDto, ShoppingBag>();
            CreateMap<AdminDto, User>();
            CreateMap<User, AdminDto>();

        }
    }
}
