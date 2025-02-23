// See https://aka.ms/new-console-template for more information

string[] cmdargs = args;

int fah = int.Parse(args[0]);
int C = (int) ((fah - 32.0) * (5.0/9.0));

Console.WriteLine(C);

