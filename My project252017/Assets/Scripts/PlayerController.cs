using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private Camera camera;

    public float jumpForce = 10f;
    private bool isGrounded = true;

    public BoxCollider2D boundary;

    private Vector2 minBounds;
    private Vector2 maxBounds;


    protected override void Start()
    {
        base.Start();
        camera = Camera.main;

       // minBounds = boundary.bounds.min;
       // minBounds = boundary.bounds.max;
    }

    /*
    private void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minBounds.x, maxBounds.x);
        pos.y = Mathf.Clamp(pos.y, minBounds.y, maxBounds.y);
        transform.position = pos;
    }
    */

    protected override void HandleAction()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        movementDirection = new Vector2(horizontal, 0).normalized;

        if (lookDirection.magnitude < .9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}