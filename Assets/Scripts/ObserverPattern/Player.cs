using UnityEngine;

namespace Assets.Scripts.ObserverPattern
{
    public class Player : MonoBehaviour,IObserver
    {
        private Animator _animator;

        private void Start()
        {
            _animator = GetComponent<Animator>();
            PublishersManager.GetPublisher<PlayerStateManager>().OnSendNotification += UpdateObserver;
        }
        
        public void UpdateObserver(string newState)
        {
            _animator.SetTrigger(newState);
        }
    }
}
