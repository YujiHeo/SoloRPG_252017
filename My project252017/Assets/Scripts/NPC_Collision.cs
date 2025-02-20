using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NPC_Collision : MonoBehaviour
{
    public SpriteRenderer interactionE; //�� ���� �޾ƾߵǴ� ��ũ��Ʈ!
    public Animator Interaction;

    void Start()
    {
        interactionE = GetComponentInChildren<SpriteRenderer>();
        interactionE.enabled = false;
        Interaction.GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("player"))
        {
            interactionE.enabled = true;
            Interaction.SetTrigger("PopUp");
        }
    }

    private void Update()
    {
        if (interactionE.enabled == true & Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("FlappyGameScene");
        }
    }
    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("player"))
        {
            interactionE.enabled = false;
            Interaction.SetTrigger("PopUp");
        }
    }
}
