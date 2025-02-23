// See https://aka.ms/new-console-template for more information
string[] cmdargs = Environment.GetCommandLineArgs();

int v = int.Parse(cmdargs[0]);

for(int i = 1; i <= 12; i++) {
    Console.WriteLine(v * i);
}


