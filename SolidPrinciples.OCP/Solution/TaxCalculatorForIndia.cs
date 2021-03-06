﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OCP.Solution
{
    class TaxCalculatorForIndia : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public string Country { get; set; }

        public decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;

            return taxableIncome * 15 / 100;
        }
    }
}
