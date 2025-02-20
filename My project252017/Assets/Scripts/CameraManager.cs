using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager sharedinstance = null;

    [HideInInspector]public CinemachineVirtualCamera virtualCamera;

    public BoxCollider2D cameraBoundary;

    public new static Camera camera;

    public Transform player;
    public Vector3 offset;

    private float minX, maxX, minY, maxY;

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

        if (cameraBoundary != null)
        {
            // Collider의 bounds를 이용하여 경계값을 계산
            minX = cameraBoundary.bounds.min.x;
            maxX = cameraBoundary.bounds.max.x;
            minY = cameraBoundary.bounds.min.y;
            maxY = cameraBoundary.bounds.max.y;
        }

    }

    private void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, -10);
    }

    private void LateUpdate()
    {
        if (player !=null)
        {
            float clampedX = Mathf.Clamp(player.position.x, minX, maxX);
            float clampedY = Mathf.Clamp(player.position.y, minY, maxY);
            transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    }

}
