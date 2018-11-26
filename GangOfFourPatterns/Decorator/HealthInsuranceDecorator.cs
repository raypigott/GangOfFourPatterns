namespace GangOfFourPatterns.Decorator
{
    public class HealthInsuranceDecorator : AbstractTaxDecorator
    {
        private readonly ISalaryCalculator salaryCalculator;

        public HealthInsuranceDecorator(ISalaryCalculator salaryCalculator) : base(salaryCalculator)
        {
            this.salaryCalculator = salaryCalculator;
        }

        protected override double ApplyTax(double salary)
        {
            return salary - 200.0;
        }
    }
}