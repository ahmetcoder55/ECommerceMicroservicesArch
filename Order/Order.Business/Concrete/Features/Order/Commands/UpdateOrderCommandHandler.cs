using AutoMapper;
using MediatR;
using Order.DataAccess.Abstract.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Business.Concrete.Features.Order.Commands
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, bool>
    {
        private readonly IRepositoryManager _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IRepositoryManager unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.OrderRepository.GetByIdAsync(request.Id);
            if (entity == null) return false;

            _mapper.Map(request, entity);

            _unitOfWork.OrderRepository.Update(entity);
            await _unitOfWork.SaveAsync();

            return true;
        }
    }
}
