using Bugs_N_Roses.Domain.Entities;
using Bugs_N_Roses.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugs_N_Roses.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

    }
}
