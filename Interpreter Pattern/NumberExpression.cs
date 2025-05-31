// السياق
// تعبير مجرد
// تعبير نهائي للأرقام
class NumberExpression : Expression
{
    private int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public override void Interpret(Context context)
    {
        context.Output = _number;
    }
}
