namespace GeometryFigures
{
    public class Rectangle : IFigure
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; }
        public double Height { get; }

        public T AcceptVisitor<T>(IFiguresVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}