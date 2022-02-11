namespace Assets.Scripts.Command_Pattern
{
    public class RightCommand : ICommand
    {
        public string Name => "Right";
        public void ExecuteCommand(Player player)
        {
            player.MoveRight();
        }
    }
}
