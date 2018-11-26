using FluentAssertions;
using GangOfFourPatterns.Decorator;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.DecoratorTests
{
    [TestFixture]
    public class FunctionalCalculatorTests
    {
        [Test]
        public void Monthly_ShouldBe_1000()
        {
            var result = FunctionalCalculator.Monthly(12000);
            result.Should().Be(1000);
        }

        [Test]
        public void GeneralTax_ShouldBe_800()
        {
            var monthly = FunctionalCalculator.Monthly(12000);
            var result = FunctionalCalculator.GeneralTax(monthly);
            result.Should().Be(800);
        }

        [Test]
        public void RegionalTax_ShouldBe_950()
        {
            var monthly = FunctionalCalculator.Monthly(12000);
            var result = FunctionalCalculator.RegionalTax(monthly);
            result.Should().Be(950);
        }

        [Test]
        public void HealthInsurance_ShouldBe_800()
        {
            var monthly = FunctionalCalculator.Monthly(12000);
            var result = FunctionalCalculator.HealthInsurance(monthly);
            result.Should().Be(800);
        }

        [Test]
        public void Netsalary_ShouldBe_1700()
        {
            var netSalary = FunctionalCalculator.calculate(30000);

            netSalary.Should().Be(1700);
        }

        [Test]
        public void GeneralTax_ShouldBe_2000()
        {
            var calculate = FunctionalCalculator.Monthly.Then(FunctionalCalculator.GeneralTax);

            var salary = calculate(30000);

            salary.Should().Be(2000);
        }
    }
}