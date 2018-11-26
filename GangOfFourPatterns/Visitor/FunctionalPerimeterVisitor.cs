using System;

namespace GangOfFourPatterns.Visitor
{
    /*
    * If you have C#7 you can use Pattern Matching
    * https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching
    */

    public static class FunctionalPerimeterVisitor
    {
        public static double Visit(object shape)
        {
            var square = shape as Square;
            if (square != null)
            {
                return 4 * square.Side;
            }
            var circle = shape as Circle;
            if (circle != null)
            {
                return 2 * Math.PI * circle.Radius;
            }

            var rectangle = shape as Rectangle;
            if (rectangle != null)
            {
                return (2 * rectangle.Height + 2 * rectangle.Width);
            }
            throw new ArgumentException("shape is not a recognized shape", nameof(shape));
        }
    }
}