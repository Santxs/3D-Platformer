using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float verticalVelocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(controller.isGrounded)
        {
            verticalVelocity = -1;

            if (Input.GetKeyDown(KeyCode.Space))
                verticalVelocity = 10;
        }
        else
        {
            verticalVelocity -= 14 * Time.deltaTime;
        }

        moveVector = Vector3.zero;
        moveVector.x Input.GetAxis("Horizontal") * 5;
        moveVector.y = verticalVelocity;

        controller.Move(moveVector * Time.deltaTime);

    }

    
}