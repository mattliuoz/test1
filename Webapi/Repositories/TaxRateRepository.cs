using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Webapi.Entities;

namespace Webapi.Repositories
{

    public class TaxRateRepository : IRepository
    {
        public TaxRateRepository()
        {
        }

        public async Task<IEnumerable<IEntity>> GetAllAsync(CancellationToken cancellationToken)
        {
            //Notes: Let's pretent following data are coming from DB or some kind of data storage
            //Assume all taxrate records are validated when saved into storage
            var taxRates = new List<TaxRate>();
            var taxRateTier1 = new TaxRate(1, DateTime.UtcNow,null, 18200m, 0m);
            var taxRateTier2 = new TaxRate(2, DateTime.UtcNow,18201m, 37000m, 0.19m);
            var taxRateTier3 = new TaxRate(3, DateTime.UtcNow,37001m, 87000m, 0.325m);
            var taxRateTier4 = new TaxRate(4, DateTime.UtcNow,87001m, 180000m, 0.37m);
            var taxRateTier5 = new TaxRate(5, DateTime.UtcNow,180001m, null, 0.45m);
            
            return await Task.FromResult(taxRates);
        }
    }


}