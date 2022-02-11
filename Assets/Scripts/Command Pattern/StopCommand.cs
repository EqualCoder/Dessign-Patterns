namespace Assets.Scripts.Command_Pattern
{
    public class StopCommand : ICommand
    {
        public string Name => "Normal";
        public void ExecuteCommand(Player player)
        {
            player.Stop();
        }
    }
}
