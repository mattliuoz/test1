using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Webapi.Domains;
using Webapi.Entities;
using Xunit;

namespace Test
{
    public class PayslipHandlerTests
    {
        [Fact]
        public async Task CalculatePayslipCommand_Should_Return_Payslip()
        {
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken cancellation = source.Token;

            var sut = new PayslipHandler();
            var taxRates = new List<TaxRate>();
            var taxRateTier1 = new TaxRate(1, DateTime.UtcNow,null, 18200m, 0m);
            var taxRateTier2 = new TaxRate(2, DateTime.UtcNow,18201m, 37000m, 0.19m);
            var taxRateTier3 = new TaxRate(3, DateTime.UtcNow,37001m, 87000m, 0.325m);
            var taxRateTier4 = new TaxRate(4, DateTime.UtcNow,87001m, 180000m, 0.37m);
            var taxRateTier5 = new TaxRate(5, DateTime.UtcNow,180001m, null, 0.45m);

            var result = await sut.Handle(new CalculatePayslipCommand("test","blah",120000,0.09m, PayMonth.January, taxRates), cancellation);
            Assert.Equal(2m, result.IncomeTax);
        }
    }
}
