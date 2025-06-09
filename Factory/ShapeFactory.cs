public class ShapeFactory
{
    public IShape GetShape(string shapeType)
    {
        if (string.IsNullOrEmpty(shapeType))
            return null;

        switch (shapeType.ToLower())
        {
            case "circle":
                return new Circle();
            case "rectangle":
                return new Rectangle();
            case "square":
                return new Square();
            default:
                return null;
        }
    }
}
