namespace GangOfFourPatterns.Decorator
{
    public class GeneralTaxDecorator : AbstractTaxDecorator
    {
        private readonly ISalaryCalculator salaryCalculator;

        public GeneralTaxDecorator(ISalaryCalculator salaryCalculator) : base(salaryCalculator)
        {
            this.salaryCalculator = salaryCalculator;
        }

        protected override double ApplyTax(double salary)
        {
            return salary * 0.8;
        }
    }
}