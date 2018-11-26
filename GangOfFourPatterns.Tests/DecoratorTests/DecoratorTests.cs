using System;
using FluentAssertions;
using GangOfFourPatterns.Decorator;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.DecoratorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Calculate_GivenDecorators_CalculatesNetSalary()
        {
            var netSalary = new HealthInsuranceDecorator(
                new RegionalTaxDecorator(
                    new GeneralTaxDecorator(
                        new DefaultSalaryCalculator())))
                .Calculate(30000);

            Console.WriteLine((double) netSalary);
            netSalary.Should().Be(1700);
        }
    }
}