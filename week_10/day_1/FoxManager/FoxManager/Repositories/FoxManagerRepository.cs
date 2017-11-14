using FoxManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class FoxManagerRepository
    {
        FoxManagerContext FoxManagerContext;

        public FoxManagerRepository(FoxManagerContext foxManagerContext)
        {
            FoxManagerContext = foxManagerContext;
        }
    }
}
