using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.ObserverPattern
{
    public class PublishersManager : MonoBehaviour
    {
        private static PublishersManager _instance;
        private List<Publisher> _publishers;

        private void Awake()
        {
            if(_instance != null) return;
            _instance = this;
            
            _publishers = new List<Publisher>();
            foreach (Transform child in transform)
            {
                if (!child.TryGetComponent(out Publisher publisher)) continue;
                
                _publishers.Add(publisher);
            }
        }

        public static T GetPublisher<T>() where T : Publisher
        {
            var pub = _instance._publishers.FirstOrDefault(publisher => publisher is T);
            if (pub == null) throw new Exception("Required Publisher Isn't Found");
            return pub as T;
        }
    }
}
