using System.Collections.Generic;
using MediatR;
using Webapi.Entities;

namespace Webapi.Domains
{
    public class Payslip
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PayStartDate { get; set; }
        public string PayEndDate { get; set; }
        public decimal NetIncome { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal Super { get; set; }

    }
}