using System.Collections.Generic;
using MediatR;
using Webapi.Entities;

namespace Webapi.Domains
{
    public class GetPayslipCommand : IRequest<string>
    {
        public int EmployeeId { get; }
        public PayMonth PayMonth { get; }
        public GetPayslipCommand(int employeeId, PayMonth payMonth)
        {
            EmployeeId = employeeId;
            PayMonth = payMonth;
        }
    }

    public class CalculatePayslipCommand : IRequest<Payslip>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public decimal AnnualSalary { get; }
        public decimal SuperRate { get; }
        public PayMonth PayMonth { get; }
        public IEnumerable<TaxRate> TaxRates { get; }
        public CalculatePayslipCommand(string firstName, string lastName, decimal annualSalary, decimal superRate, PayMonth payMonth, IEnumerable<TaxRate> taxRates)
        {
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
            SuperRate = superRate;
            PayMonth = payMonth;
            TaxRates = taxRates;
        }
    }
}