using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager sharedinstance = null;

    [HideInInspector]public CinemachineVirtualCamera virtualCamera;

    public static BoxCollider2D cameraBoundary;

    public new static Camera camera;

    public Transform player;
    public Vector3 offset;


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

        /*
        GameObject vCamGameObject = GameObject.FindWithTag("VirtualCamera");
        virtualCamera = vCamGameObject.GetComponent<CinemachineVirtualCamera>();
        */
    }

    private void Start()
    {
        //cameraBoundary = GetComponentInChildren<BoxCollider2D>();

        
    }

    private void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, -10);
    }
}
