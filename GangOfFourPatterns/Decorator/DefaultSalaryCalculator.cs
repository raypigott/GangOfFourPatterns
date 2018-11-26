namespace GangOfFourPatterns.Decorator
{
    public class DefaultSalaryCalculator : ISalaryCalculator
    {
        public double Calculate(double grossAnnual)
        {
            return grossAnnual / 12;
        }
    }
}