using System;

namespace GeometryFigures
{
    public interface IFigure
    {
        T AcceptVisitor<T>(IFiguresVisitor<T> visitor);
    }
}
