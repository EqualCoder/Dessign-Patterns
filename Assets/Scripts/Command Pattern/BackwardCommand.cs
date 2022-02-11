namespace Assets.Scripts.Command_Pattern
{
    public class BackwardCommand : ICommand
    {
        public string Name => "Backward";
        public void ExecuteCommand(Player player)
        {
            player.MoveBack();
        }
    }
}
