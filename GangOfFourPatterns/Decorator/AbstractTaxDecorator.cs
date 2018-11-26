namespace GangOfFourPatterns.Decorator
{
    public abstract class AbstractTaxDecorator : ISalaryCalculator
    {
        private readonly ISalaryCalculator salaryCalculator;

        protected AbstractTaxDecorator(ISalaryCalculator salaryCalculator)
        {
            this.salaryCalculator = salaryCalculator;
        }

        protected abstract double ApplyTax(double salary);

        public double Calculate(double grossAnnual)
        {
            var salary = salaryCalculator.Calculate(grossAnnual);
            return ApplyTax(salary);
        }
    }
}