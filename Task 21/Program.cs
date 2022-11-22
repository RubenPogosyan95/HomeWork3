Console.WriteLine("Select X1, Y1, Z1 - ");
var X1 = Convert.ToInt32(Console.ReadLine());
var Y1 = Convert.ToInt32(Console.ReadLine());
var Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select X2, Y2, Z2 - ");
var X2 = Convert.ToInt32(Console.ReadLine());
var Y2 = Convert.ToInt32(Console.ReadLine());
var Z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow((X1 - X2),2) + Math.Pow((Y1 - Y2),2) + Math.Pow((Z1 - Z2),2)));
