using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedinstance = null;

    public CameraManager cameraManager;

    public SpawnPoint playerSpawnPoint;


    private void Awake()
    {
        if(sharedinstance != null && sharedinstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            sharedinstance = this;
        }
    }

    void Start()
    {
        SetupScene();
    }
    public void SetupScene()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        if (playerSpawnPoint != null)
        {
            GameObject player = playerSpawnPoint.SpawnObject();
            cameraManager.virtualCamera.Follow = player.transform;
        }
    }
}
