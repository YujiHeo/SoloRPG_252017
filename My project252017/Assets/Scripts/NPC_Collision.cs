using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Collision : MonoBehaviour
{
    public SpriteRenderer interactionE; //�� ���� �޾ƾߵǴ� ��ũ��Ʈ!

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
