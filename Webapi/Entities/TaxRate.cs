using System;

namespace Webapi.Entities
{
    public class TaxRate:IEntity
    {
        public int Id { get ; set ; }
        public DateTime? LastUpdate { get; set; }
        public decimal? MinTaxableIncome { get; set; }
        public decimal? MaxTaxableIncome { get; set; }
        public decimal Rate { get; }
        public TaxRate(int id, DateTime? lastUpdate, decimal? minTaxableIncome, decimal? maxTaxableIncome, decimal rate)
        {
            Id = id;
            LastUpdate=lastUpdate;
            MinTaxableIncome = minTaxableIncome;
            MaxTaxableIncome = maxTaxableIncome; 
            Rate = Rate;
        }
    }
}