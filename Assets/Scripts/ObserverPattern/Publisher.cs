using System;
using UnityEngine;

namespace Assets.Scripts.ObserverPattern
{
    public abstract class Publisher : MonoBehaviour
    {
        public event Action<string> OnSendNotification;

        protected virtual void NotifyObservers(string newState) => OnSendNotification?.Invoke(newState);
        
    }
}
