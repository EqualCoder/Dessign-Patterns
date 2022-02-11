using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ObserverPattern
{
    public enum State
    {
        Shoot,Jump,Normal,Walk
    }
    public class PlayerStateManager : Publisher
    {
        private static PlayerStateManager _instance;
        private string _playerState;
        private State _state;
        private List<IObserver> _observers = new List<IObserver>();

        private void Awake()
        {
            if(_instance!=null)return;
            _instance = this;
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                _state = State.Shoot;
                SetPlayerState(_state.ToString());
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                _state = State.Jump;
                SetPlayerState(_state.ToString());
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                _state = State.Normal;
                SetPlayerState(_state.ToString());
            }

            else if (Input.GetKeyDown(KeyCode.W))
            {
                _state = State.Walk;
                SetPlayerState(_state.ToString());
            }
        }
        protected override void NotifyObservers(string state)
        {
            base.NotifyObservers(state);
        }
        

        private void SetPlayerState(string state)
        {
            _playerState = state;
            NotifyObservers(_playerState);
        }
    }
}
