public class DecrementCommand : ICommand
{
    private int _savedValue;

    public int Execute(int result)
    {
        _savedValue = result; // Save before operation for undo
        return result - 1;
    }

    public int Undo() => _savedValue;
}