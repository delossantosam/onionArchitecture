using Domain.Entities;
using Domain.Interfaces;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Repositories
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
