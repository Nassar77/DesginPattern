using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern;
class AddExpression : Expression
{
    private Expression _left;
    private Expression _right;

    public AddExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public override void Interpret(Context context)
    {
        var leftContext = new Context();
        var rightContext = new Context();

        _left.Interpret(leftContext);
        _right.Interpret(rightContext);

        context.Output = leftContext.Output + rightContext.Output;
    }
}
