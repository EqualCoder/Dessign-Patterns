namespace Assets.Scripts.Command_Pattern
{
    public class ForwardCommand : ICommand
    {
        public string Name => "Forward";
        public void ExecuteCommand(Player player)
        {
            player.MoveForward();
        }
        
    }
}
