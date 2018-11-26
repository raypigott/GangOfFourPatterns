using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using GangOfFourPatterns.Visitor;
using NUnit.Framework;

namespace GangOfFourPatterns.Tests.VisitorTests
{
    [TestFixture]
    public class PerimeterVisitorTests
    {
        private List<Element> figures;

        [SetUp]
        public void SetUp()
        {
            var circle = new Circle(4);
            var square = new Square(5);
            var rectangle = new Rectangle(6, 7);

            figures = new List<Element> { circle, square, rectangle };
        }

        [Test]
        public void TotalArea_ShouldBe_Correct()
        {
            Visitor<double> areaVisitor = new AreaVisitor();

            var totalArea = figures.Sum(figure => figure.accept(areaVisitor));

            Console.WriteLine(totalArea);

            totalArea.Should().Be(117.26548245743669);
        }

        [Test]
        public void TotalPerimeter_ShouldBe_Correct()
        {
            Visitor<double> perimeterVisitor = new PerimeterVisitor();

            var totalPerimeter = figures.Sum(figure => figure.accept(perimeterVisitor));

            Console.WriteLine(totalPerimeter);

            totalPerimeter.Should().Be(71.132741228718345);
        }

        [Test]
        public void SquareArea_ShouldBe_Correct()
        {
            Visitor<double> areaVisitor = new AreaVisitor();
            var square = new Square(5);
            var elements = new List<Element> { square };
            var totalArea = elements.Sum(figure => figure.accept(areaVisitor));
            totalArea.Should().Be(25);
        }

        [Test]
        public void SquarePerimeter_ShouldBe_Correct()
        {
            Visitor<double> perimeterVisitor = new PerimeterVisitor();
            var square = new Square(5);
            var elements = new List<Element> { square };
            var totalPerimeter = elements.Sum(figure => figure.accept(perimeterVisitor));
            totalPerimeter.Should().Be(20);
        }

        [Test]
        public void FunctionalSquareArea_ShouldBe_Correct()
        {
            var square = new Square(5);
            var elements = new List<Element> { square };
            var totalArea = elements.Sum(element => FunctionalAreaVisitor.Visit(element));
            totalArea.Should().Be(25);
        }

        [Test]
        public void FunctionalPerimeter_ShouldBe_Correct()
        {
            var square = new Square(5);
            var elements = new List<Element> { square };
            var totalPerimeter = elements.Sum(element => FunctionalPerimeterVisitor.Visit(element));
            totalPerimeter.Should().Be(20);
        }

        [Test]
        public void FunctionalTotalPerimeter_ShouldBe_Correct()
        {
            var totalPerimeter = figures.Sum(figure => FunctionalPerimeterVisitor.Visit(figure));
            Console.WriteLine(totalPerimeter);
            totalPerimeter.Should().Be(71.132741228718345);
        }

        [Test]
        public void FunctionalTotalArea_ShouldBe_Correct()
        {
            var totalArea = figures.Sum(figure => FunctionalAreaVisitor.Visit(figure));
            Console.WriteLine(totalArea);
            totalArea.Should().Be(117.26548245743669);
        }
    }
}
