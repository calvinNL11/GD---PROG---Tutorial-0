using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10f;  
    [SerializeField] private LayerMask groundLayer;  

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = IsGrounded();

        // Jumping logic
        if (isGrounded && Input.GetButtonDown("Jump"))  
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

   
    bool IsGrounded()
    {
        RaycastHit hit;
        return Physics.Raycast(transform.position, Vector3.down, out hit, 1f, groundLayer);
    }
}