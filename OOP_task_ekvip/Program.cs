if (args.Length != 1)
{
    Console.WriteLine(" Please provide one initial number as a command-line argument." );
    return;
}

int result = int.Parse(args[0]);
Console.WriteLine($" initial number : {result}" );

while (true)
{
    string? command = Console.ReadLine();
    Console.WriteLine($" command : {command}" );
}