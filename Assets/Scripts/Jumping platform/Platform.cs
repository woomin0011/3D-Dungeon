using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [Header("JumpSettings")]
    public float jumpForce;

    Rigidbody _rigidbody;
   

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void AddJumpForce(Rigidbody rb)
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody otherRb = other.GetComponent<Rigidbody>();
        if (otherRb != null)
        {
            AddJumpForce(otherRb);
        }
    }
}
