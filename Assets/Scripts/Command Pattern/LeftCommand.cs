namespace Assets.Scripts.Command_Pattern
{
    public class LeftCommand : ICommand
    {
        public string Name => "Left";
        public void ExecuteCommand(Player player)
        {
            player.MoveLeft();
        }
    }
}
