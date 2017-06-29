using System;
using GeometryFigures;

namespace VisitorImplementations.Builder
{
    internal class FiguresVisitorFromBuilder<T> : IFiguresVisitor<T>
    {
        private Func<T> _else;
        private Func<Circle, T> _ifCircle;
        private Func<Rectangle, T> _ifRectangle;
        private Func<Triangle, T> _ifTriangle;

        public T Visit(Rectangle rectangle) => _ifRectangle == null ? _else() : _ifRectangle(rectangle);

        public T Visit(Triangle triangle) => _ifTriangle == null ? _else() : _ifTriangle(triangle);

        public T Visit(Circle circle) => _ifCircle == null ? _else() : _ifCircle(circle);

        public void SetIfCircle(Func<Circle, T> ifCircle)
        {
            if (_ifCircle != null)
                throw new ArgumentException("ifCircle already exists");
            _ifCircle = ifCircle;
        }

        public void SetIfRectangle(Func<Rectangle, T> ifRectangle)
        {
            if (_ifRectangle != null)
                throw new ArgumentException("ifRectangle already exists");
            _ifRectangle = ifRectangle;
        }

        public void SetIfTriangle(Func<Triangle, T> ifTriangle)
        {
            if (_ifTriangle != null)
                throw new ArgumentException("ifTriangle already exists");
            _ifTriangle = ifTriangle;
        }

        public void SetElse(Func<T> @else)
        {
            if (_else != null)
                throw new ArgumentException("else already exists");
            _else = @else;
        }
    }
}