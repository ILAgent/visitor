using System;
using GeometryFigures;

namespace VisitorImplementations.Builder
{
    public static class FiguresVisitorBuilderExtensions
    {
        public static IFiguresVisitorBuilder<T> IfRectangle<T>(this IFigure figure, Func<Rectangle, T> ifRectangle)
        {
            var builder = new FiguresVisitorBuilder<T>(figure);
            return builder.IfRectangle(ifRectangle);
        }

        public static IFiguresVisitorBuilder<T> IfCircle<T>(this IFigure figure, Func<Circle, T> ifCircle)
        {
            var builder = new FiguresVisitorBuilder<T>(figure);
            return builder.IfCircle(ifCircle);
        }

        public static IFiguresVisitorBuilder<T> IfTriangle<T>(this IFigure figure, Func<Triangle, T> ifTriangle)
        {
            var builder = new FiguresVisitorBuilder<T>(figure);
            return builder.IfTriangle(ifTriangle);
        }
    }
}