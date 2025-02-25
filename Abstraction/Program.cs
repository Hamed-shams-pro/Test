

using Abstraction;

//Student student = new Student()
//{
//    Name = "Splinter"
//};
//student.Family = "Shams";
//student.IsValidate(19);
//Console.WriteLine(student.PrintInfo());
//student.Test();

//Product product = new Product("Chips", "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
//Market market = new Market(product, 30);
//market.Name = "Seven";
//Console.WriteLine($"{market.Name} {market.Product.Title} {market.Product.Description} {market.count}");

//Action<int, int> action = (n1, n2) =>
//{
//    Console.WriteLine(n1 + n2);
//};
//action += (n1, n2) =>
//{
//    Console.WriteLine(n1 * n2);
//};
//action(3, 2);

//Func<int, int, int> func = (n1, n2) =>
//{
//    return n1 + n2;
//};
//Console.WriteLine(func(6, 4));


Rule rule = new Rule()
{
    Name = "Hamed",
    Family = "Shams"
};
rule.Higth = 193;
rule.EyeColor = Color.Brown;
Console.WriteLine(rule.PrintInfo());