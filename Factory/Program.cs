class Program
{
    static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        IShape shape1 = factory.GetShape("circle");
        shape1?.Draw();  // رسم دائرة

        IShape shape2 = factory.GetShape("rectangle");
        shape2?.Draw();  // رسم مستطيل

        IShape shape3 = factory.GetShape("square");
        shape3?.Draw();  // رسم مربع
    }
}
