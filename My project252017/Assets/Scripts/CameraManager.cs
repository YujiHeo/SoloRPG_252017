using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager sharedinstance = null;

    [HideInInspector]public CinemachineVirtualCamera virtualCamera;

    private void Awake()
    {
        if (sharedinstance != null && sharedinstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            sharedinstance = this;
        }

        GameObject vCamGameObject = GameObject.FindWithTag("VirtualCamera");
        virtualCamera = vCamGameObject.GetComponent<CinemachineVirtualCamera>();
    }
}
