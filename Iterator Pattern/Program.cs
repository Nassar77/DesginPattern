
var names = new NameCollection();
names.Add("Ahmed");
names.Add("Sara");
names.Add("Khaled");

var iterator = names.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
