public interface ICommand
{
    int Execute(int result);
    int Undo();
}