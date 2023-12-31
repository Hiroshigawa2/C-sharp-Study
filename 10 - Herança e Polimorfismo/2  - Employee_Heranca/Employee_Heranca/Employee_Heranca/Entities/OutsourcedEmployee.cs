﻿namespace Employee_Heranca.Entities
{
    internal class OutsourcedEmployee : Employee
    {

        public double AdditionalCharge;
        public OutsourcedEmployee() { }
        public OutsourcedEmployee (string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour) 
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge + ((AdditionalCharge * 0.10));

        }

    }
}
