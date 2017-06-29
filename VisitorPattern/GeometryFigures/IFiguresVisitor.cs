namespace GeometryFigures
{
    public interface IFiguresVisitor<out T>
    {
        T Visit(Rectangle rectangle);
        T Visit(Triangle triangle);
        T Visit(Circle circle);
    }
}