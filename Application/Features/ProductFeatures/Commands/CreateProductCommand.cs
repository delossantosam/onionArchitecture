using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            private readonly IUnitOfWork _unitOfWork;

            public CreateProductCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
            {
                var product = new Product 
                { 
                    Barcode = command.Barcode,
                    Name = command.Name,
                    Description = command.Description,
                    Rate = command.Rate
                };                                

                _unitOfWork.Product.Add(product);                
                await _unitOfWork.CompleteAsync();                               
                
                return product.Id;
            }
        }
    }
}
