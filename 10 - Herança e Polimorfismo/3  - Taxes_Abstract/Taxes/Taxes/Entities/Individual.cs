﻿namespace Taxes.Entities
{
    internal class Individual : TaxesPays
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }
        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        { 
            HealthExpenditures = healthExpenditures;
        }

        public override double IncomeTaxe()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else 
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}
