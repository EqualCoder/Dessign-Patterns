using Assets.Scripts.Command_Pattern;
using UnityEngine;

public class MovementCommand : ICommand
{
    private Vector3 direction;
    public string Name { get; }

    public MovementCommand(Player player, Vector3 inDirection)
    {
        direction = inDirection;
    }
    
    public void ExecuteCommand(Player player)
    {
    }
} 