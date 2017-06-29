namespace GeometryFigures
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public T AcceptVisitor<T>(IFiguresVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}