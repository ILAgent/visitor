using System;
using GeometryFigures;

namespace VisitorImplementations.Builder
{
    public interface IFiguresVisitorBuilder<T>
    {
        IFiguresVisitorBuilder<T> IfRectangle(Func<Rectangle, T> ifRectangle);
        IFiguresVisitorBuilder<T> IfCircle(Func<Circle, T> ifCircle);
        IFiguresVisitorBuilder<T> IfTriangle(Func<Triangle, T> ifTriangle);
        T Else(Func<T> @else);
    }
}