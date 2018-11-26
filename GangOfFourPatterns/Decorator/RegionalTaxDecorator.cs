namespace GangOfFourPatterns.Decorator
{
    public class RegionalTaxDecorator : AbstractTaxDecorator
    {
        private readonly ISalaryCalculator salaryCalculator;

        public RegionalTaxDecorator(ISalaryCalculator salaryCalculator) : base(salaryCalculator)
        {
            this.salaryCalculator = salaryCalculator;
        }

        protected override double ApplyTax(double salary)
        {
            return salary * 0.95;
        }
    }
}