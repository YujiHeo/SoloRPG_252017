using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedinstance = null;

    public CameraManager cameraManager;

    public Transform playerSpawnPoint;
    public GameObject player;

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
        //player = GameObject.FindWithTag("SpawnPoint");
        player.transform.position = new Vector2(playerSpawnPoint.transform.position.x, playerSpawnPoint.transform.position.y);
    }
}
