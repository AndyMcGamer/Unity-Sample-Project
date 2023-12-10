using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    // You should be declaring MOST of your variables like so:
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private Transform mainCamera;

    private Vector2 playerInput;
    private void Awake()
    {
        
    }

    private void Update()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        playerInput.Normalize();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        }
        
    }

    private void FixedUpdate()
    {
        Vector3 moveDir = (playerInput.y * mainCamera.forward) + (playerInput.x * mainCamera.right);
        moveDir.Normalize();
        rb.velocity = new Vector3(moveDir.x * speed, rb.velocity.y, moveDir.z * speed);
    }
}
