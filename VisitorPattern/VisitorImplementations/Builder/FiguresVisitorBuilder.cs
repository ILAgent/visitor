using System;
using GeometryFigures;

namespace VisitorImplementations.Builder
{
    internal class FiguresVisitorBuilder<T> : IFiguresVisitorBuilder<T>
    {
        private readonly IFigure _figure;
        private readonly FiguresVisitorFromBuilder<T> _visitor = new FiguresVisitorFromBuilder<T>();

        public FiguresVisitorBuilder(IFigure figure)
        {
            _figure = figure;
        }
        public IFiguresVisitorBuilder<T> IfRectangle(Func<Rectangle, T> ifRectangle)
        {
            _visitor.SetIfRectangle(ifRectangle);
            return this;
        }

        public IFiguresVisitorBuilder<T> IfCircle(Func<Circle, T> ifCircle)
        {
            _visitor.SetIfCircle(ifCircle);
            return this;
        }

        public IFiguresVisitorBuilder<T> IfTriangle(Func<Triangle, T> ifTriangle)
        {
            _visitor.SetIfTriangle(ifTriangle);
            return this;
        }

        public T Else(Func<T> @else)
        {
            _visitor.SetElse(@else);
            return _figure.AcceptVisitor(_visitor);
        }
    }
}