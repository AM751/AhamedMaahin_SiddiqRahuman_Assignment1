public interface ICommand
{
    //Command executing zone:
    public void Execute();

   public bool IsComplete {get;}
}
