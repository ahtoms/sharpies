// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter value for A: ");
string? A = Console.ReadLine();
Console.WriteLine("Enter value for B: ");
string? B = Console.ReadLine();

int Adig = int.Parse(A);
int Bdig = int.Parse(B);

Console.WriteLine("");
if(Adig == Bdig) {
    Console.WriteLine($"{Adig} is the largest but the other value was the same");
} else if(Adig > Bdig) {
    Console.WriteLine($"{Adig} is the largest");
} else {
    Console.WriteLine($"{Bdig} is the largest");
}
