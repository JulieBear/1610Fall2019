using System;
using UnityEngine;
using UnityEngine.Events;

namespace Script
{
    public class TriggerEvents : MonoBehaviour
    {
        public UnityEvent triggerEvent;
            
        // W: ontrigger
        private void OnTriggerEnter(Collider other)
        {
            triggerEvent.Invoke();
            print("work");
        }

        private void OnTriggerExit(Collider other)
        {
            triggerEvent.Invoke();
        }

        private void OnMouseExit()
        {
            print("let's see");
        }
    }
}
