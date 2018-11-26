using System;

namespace GangOfFourPatterns.Decorator
{
    public class FunctionalCalculator
    {
        public static Func<double, double> Monthly = grossAnnual => grossAnnual / 12;

        public static Func<double, double> GeneralTax = salary => salary * 0.8;

        public static Func<double, double> RegionalTax = salary => salary * 0.95;

        public static Func<double, double> HealthInsurance = salary => salary - 200;

        public static Func<double, double> calculate = Monthly
            .Then(GeneralTax)
            .Then(RegionalTax)
            .Then(HealthInsurance);
    }
}
