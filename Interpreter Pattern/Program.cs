using Interpreter_Pattern;

var context = new Context();
Expression expression = new AddExpression(
    new NumberExpression(1),
    new NumberExpression(2)
);
expression.Interpret(context);

Console.WriteLine($"the result = {context.Output}"); // الناتج: 3
