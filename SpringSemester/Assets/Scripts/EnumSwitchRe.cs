using System;
using UnityEngine;
using UnityEngine.Events;

public class EnumSwitchRe : MonoBehaviour
{

    public enum Says
    {
        High,
        Squat,
    }

    public Says currState;

    public UnityEvent Onmousedown, Ontriggerexit;

    private void Update()
    {
        switch (currState)
        {
              case Says.High:
                  Onmousedown.Invoke();
                  Debug.Log("practice");
                  break;
              case Says.Squat:
                  Ontriggerexit.Invoke();
                  Debug.Log("practice 2");
                  break;
        }
    }
}  