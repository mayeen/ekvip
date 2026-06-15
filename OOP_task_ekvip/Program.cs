if (args.Length != 1)
{
    Console.WriteLine(" Please provide one initial number as a command-line argument." );
    return;
}

int result = int.Parse(args[0]);

Stack<ICommand> commandHistory = new Stack<ICommand>();


while(true)
{
    string? input = Console.ReadLine();
    switch(input?.Trim().ToLower())
    {
        case "increment":
            ICommand incrementCmd = new IncrementCommand();
            result = incrementCmd.Execute(result);
            commandHistory.Push(incrementCmd);
            break;
        case "decrement":
            ICommand decrementCmd = new DecrementCommand();
            result = decrementCmd.Execute(result);
            commandHistory.Push(decrementCmd);
            break;
        case "randadd":
            ICommand randAddCmd = new RandAddCommand();
            result = randAddCmd.Execute(result);
            commandHistory.Push(randAddCmd);
            break;
            
        case "undo":
            if (commandHistory.Count == 0)
            {
                Console.WriteLine(" No commands to undo." );
            }
            else
            {
                result = commandHistory.Pop().Undo();
            }
            break;
        default:
            Console.WriteLine(" Invalid command. Use 'increment', 'decrement', 'randadd', 'undo'" );
            break;
    }
    Console.WriteLine(result );
}


    

