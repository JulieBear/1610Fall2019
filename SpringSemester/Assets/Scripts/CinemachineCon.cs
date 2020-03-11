using System;
using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineCon : MonoBehaviour
{

    public PlayerDataRe playerData;
    private CinemachineVirtualCamera virtCamera;

    private void Awake()
    {
        virtCamera = GetComponent<CinemachineVirtualCamera>();
        playerData.instanceAction = InstanceHandler;
        playerData.InstancePlayer();
    }

    private void InstanceHandler(GameObject obj)
    {
        virtCamera.Follow = obj.transform;
    }
}
