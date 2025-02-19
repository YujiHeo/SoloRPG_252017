using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Collision : MonoBehaviour
{
    public SpriteRenderer interactionE; //얘 한테 달아야되는 스크립트!

    void Start()
    {
        interactionE = GetComponentInChildren<SpriteRenderer>();
        interactionE.enabled = false;
    }

    private void Update()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
            if (collider2D.CompareTag("player"))
            {
                interactionE.enabled = true;
            }
    }

    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("player"))
        {
            interactionE.enabled = false;
        }
    }
}
