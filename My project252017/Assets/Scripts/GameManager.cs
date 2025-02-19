using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpawnPoint playerSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        SetupScene();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        }
    }
}
