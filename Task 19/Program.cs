Console.WriteLine("Select Five-digit number - ");
var Number = Convert.ToInt32(Console.ReadLine());

int size = Number.ToString().Length;

if (size == 5)
{
    int FirstLatter = Number / 10000;
    int SecondLatter = (Number / 1000) % 10;
    int LastLatter = Number % 10;
    int PenultimateLatter = (Number % 100) / 10;
    if ((FirstLatter == LastLatter) && (SecondLatter == PenultimateLatter))
    {
        Console.WriteLine("Right");
    }
    else
        Console.WriteLine("Wrong");
}
else    
    Console.WriteLine("Wrong Number");