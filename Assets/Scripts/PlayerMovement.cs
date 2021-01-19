using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public Rigidbody rBody;
    private Vector3 movement;

    void Update()
    {
        movement.z = Input.GetAxisRaw("Horizontal");        
    }

    void FIxedUpdate()
    {
        rBody.MovePosition(rBody.position + movement * Time.fixedDeltaTime);
    }
}
