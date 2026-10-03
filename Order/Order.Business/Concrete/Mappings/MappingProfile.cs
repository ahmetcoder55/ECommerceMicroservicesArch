using AutoMapper;
using Order.Business.Concrete.DTOs;
using Order.Business.Concrete.Features.Order.Commands;
using Order.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // Entity -> DTO
            CreateMap<OrderEntity, OrderDto>();

            // Command -> Entity
            CreateMap<CreateOrderCommand, OrderEntity>();
            CreateMap<UpdateOrderCommand, OrderEntity>();
        }
    }
}
