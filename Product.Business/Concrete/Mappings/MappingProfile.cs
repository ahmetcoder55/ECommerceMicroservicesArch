using AutoMapper;
using Product.Business.Concrete.DTOs;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Business.Concrete.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductEntity, ProductDto>();

            CreateMap<CreateProductCommand, ProductEntity>();
            CreateMap<UpdateProductCommand, ProductEntity>();
        }
    }
}
