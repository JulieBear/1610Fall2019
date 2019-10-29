using System;
using UnityEngine;
using UnityEngine.Events;

namespace Script
{
    public class TriggerEvents : MonoBehaviour
    {
        public UnityEvent triggerEnterEvent, triggerExitEvent;
            
        // W: ontrigger
        private void OnTriggerEnter(Collider other)
        {
            triggerEnterEvent.Invoke();
        }

        private void OnTriggerExit(Collider other)
        {
            triggerExitEvent.Invoke();
        }
    }
}
