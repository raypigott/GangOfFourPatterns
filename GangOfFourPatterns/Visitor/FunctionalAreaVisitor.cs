using System;

namespace GangOfFourPatterns.Visitor
{
    /*
     * If you have C#7 you can use Pattern Matching
     * https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching
     */
 
    public static class FunctionalAreaVisitor
    {
        public static double Visit(object shape)
        {
            var square = shape as Square;
            if (square != null)
            {
                return square.Side * square.Side;
            }
            var circle = shape as Circle;
            if (circle != null)
            {
                return circle.Radius * circle.Radius * Math.PI;
            }

            var rectangle = shape as Rectangle;
            if (rectangle != null)
            {
                return rectangle.Height* rectangle.Width;
            }
            throw new ArgumentException("shape is not a recognized shape", nameof(shape));
        }
    }
}