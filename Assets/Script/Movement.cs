using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody body;
    public float MoveSpeed;
    public Vector3 DirectionZ;
    public Vector3 DirectionX;


    private void FixedUpdate()
    {
        MovementSystem();
    }

    public void MovementSystem()
    {
        if(body != null)
        {
            if (Input.GetKey(KeyCode.A))
            {
                body.velocity += DirectionZ * MoveSpeed * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.D))
            {
                body.velocity  -= DirectionZ * MoveSpeed * Time.deltaTime;   
            }
            if (Input.GetKey(KeyCode.W))
            {
                body.velocity += DirectionX * MoveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                body.velocity -= DirectionX * MoveSpeed * Time.deltaTime;
            }

        }
    }



}
