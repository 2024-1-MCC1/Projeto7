using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;
    public float speed, maxSpeed, drag;
    public float rotationSpeed;
    public Transform cam;

    bool left, forward, backward, right;
    void Update()
    {
        HandleInput();
        LimitVelocity();
        HandleDrag();
    }

    void FixedUpdate()
    {
        HandleMovement();
        HandleRotation();
    }

    void HandleRotation()
    {
        if (new Vector2(rb.velocity.x, rb.velocity.z).magnitude > .1f)
        {
            Vector3 horizontalDir = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            Quaternion rotation = Quaternion.LookRotation(horizontalDir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed);
        }
    }

    void HandleDrag()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z) / (1 + drag / 100) + new Vector3(0, rb.velocity.y, 0);
    }

    void LimitVelocity()
    {
        Vector3 horizontalVelocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        if (horizontalVelocity.magnitude > maxSpeed)
        {
            Vector3 limitedVelocity = horizontalVelocity.normalized * maxSpeed;
            rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
        }
    }

    void HandleMovement()
    {
        Quaternion dir = Quaternion.Euler(0f, cam.rotation.eulerAngles.y, 0f);
        if (left)
        {
            rb.AddForce(dir * Vector3.left * speed);
            left = false;
        }
        if (right)
        {
            rb.AddForce(dir * Vector3.right * speed);
            right = false;
        }
        if (forward)
        {
            rb.AddForce(dir * Vector3.forward * speed);
            forward = false;
        }
        if (backward)
        {
            rb.AddForce(dir * Vector3.back * speed);
            backward = false;
        }
    }

    void HandleInput()
    {
        if (Input.GetKey(KeyCode.A))
            left = true;
        if (Input.GetKey(KeyCode.W))
            forward = true;
        if (Input.GetKey(KeyCode.S))
            backward = true;
        if (Input.GetKey(KeyCode.D))
            right = true;

    }
}
