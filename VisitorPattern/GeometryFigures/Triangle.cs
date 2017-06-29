namespace GeometryFigures
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public T AcceptVisitor<T>(IFiguresVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}