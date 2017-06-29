using System;
using GeometryFigures;

namespace VisitorImplementations
{
    public class FiguresVisitor<T> : IFiguresVisitor<T>
    {
        private readonly Func<Circle, T> _ifCircle;
        private readonly Func<Rectangle, T> _ifRectangle;
        private readonly Func<Triangle, T> _ifTriangle;

        public FiguresVisitor(Func<Rectangle, T> ifRectangle, Func<Triangle, T> ifTriangle, Func<Circle, T> ifCircle)
        {
            _ifRectangle = ifRectangle;
            _ifTriangle = ifTriangle;
            _ifCircle = ifCircle;
        }

        public T Visit(Rectangle rectangle) => _ifRectangle(rectangle);

        public T Visit(Triangle triangle) => _ifTriangle(triangle);

        public T Visit(Circle circle) => _ifCircle(circle);
    }
}