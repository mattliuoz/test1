using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Webapi.Domains
{
    public class PayslipHandler : IRequestHandler<GetPayslipCommand, string>
    , IRequestHandler<CalculatePayslipCommand, Payslip>
    {
        public async Task<string> Handle(GetPayslipCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult($"{request.EmployeeId} is requesting payslip for month: {request.PayMonth.ToString()}");
        }

        public async Task<Payslip> Handle(CalculatePayslipCommand request, CancellationToken cancellation)
        {
            //Get Tax base, from previous tiers
            var taxRates = request.TaxRates.OrderBy(t=>t.MinTaxableIncome);
            var taxBase = 0m;
            foreach(var taxRate in taxRates)
            {
                var maxTaxableIncome = taxRate.MaxTaxableIncome??request.AnnualSalary;
                var minTaxableIncome = taxRate.MinTaxableIncome?? 0m;

                if(maxTaxableIncome>=request.AnnualSalary)
                {
                    taxBase+=( maxTaxableIncome-minTaxableIncome)*taxRate.Rate;
                }
            }
            var paySlip = new Payslip(){ FirstName = request.FirstName, LastName = request.LastName, IncomeTax = taxBase};
            return await Task.FromResult(paySlip);
        }
    }
}