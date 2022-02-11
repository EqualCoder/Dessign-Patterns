using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Command_Pattern
{
    public class PlayerSelectionManager : MonoBehaviour
    {
        public  List<Player> Players;
        public static PlayerSelectionManager Instance;
        public Player currentSelectedPlayer;

        private void Awake()
        {
            if (Instance != null) return;
            Instance = this;
        }

        public void SelectPlayer(Player player)
        {
            Debug.Log($"select test ");
            foreach (var p in Players)
            {
                p._activeIndicator.SetActive(false);
            }
            player._activeIndicator.SetActive(true);
            currentSelectedPlayer = player;
        }
    }
}
