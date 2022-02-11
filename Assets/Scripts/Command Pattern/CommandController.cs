using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Command_Pattern
{
    public class CommandController : MonoBehaviour
    {
        private static CommandController _instance;
        private Button _forwardBtn;
        private Button _backwardBtn;
        private Button _leftBtn;
        private Button _rightBtn;
        private Button _stopBtn;

        private List<ICommand> _movementsCommands = new List<ICommand>();
        
        private void Awake()
        {
            if (_instance != null) return;
            _instance=this;
            InitialiseCommands();
        }

        private void InitialiseCommands()
        {
            _movementsCommands.Add(new BackwardCommand());
            _movementsCommands.Add(new ForwardCommand());
            _movementsCommands.Add(new StopCommand());
            _movementsCommands.Add(new LeftCommand());
            _movementsCommands.Add(new RightCommand());
        }

        public void ExecuteCommand(string commandName)
        {
            var targetCommand = _movementsCommands.Find(c => c.Name == commandName);
            targetCommand.ExecuteCommand(PlayerSelectionManager.Instance.currentSelectedPlayer);
        }
    }
}
