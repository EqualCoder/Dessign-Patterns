namespace Assets.Scripts.Command_Pattern
{
    public interface ICommand 
    {
        string Name { get; }
        void ExecuteCommand(Player player);
    
    }
}
