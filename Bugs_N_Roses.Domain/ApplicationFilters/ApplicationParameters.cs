using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugs_N_Roses.Domain.ApplicationFilters
{
    public abstract class ApplicationParameters
    {

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; } = 25;
        public decimal MinPrice { get; set; } = 0;
        public decimal MaxPrice { get; set; } = Decimal.MaxValue;    
    }
}
