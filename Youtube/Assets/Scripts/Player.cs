using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    public Transform groundTransform;
    public float movmentSpeed = 1.5f;
    public float jumpRate = 5f;
    float horizontalInput;
    bool jumpKeyWasPressed;
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        horizontalInput = Input.GetAxis("Horizontal")  * movmentSpeed;
    }
    private void FixedUpdate()
    {
        rigidbodyComponent.velocity = new Vector3(horizontalInput, rigidbodyComponent.velocity.y, 0);
        if (Physics.OverlapSphere(groundTransform.position, 0.1f).Length == 1)
        {
            return;
        }
        if (jumpKeyWasPressed)
        {
            rigidbodyComponent.AddForce(Vector3.up * jumpRate, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }  
}