public class RandAddCommand :ICommand 
{
    private int _savedValue;

    public int Execute(int result)
    {
        _savedValue = result; // Save before operation for undo
        Random rand = new Random();
        return rand.Next(1, 100); //assume we select a random number between 1 and 100
    }

    public int Undo() => _savedValue;
}