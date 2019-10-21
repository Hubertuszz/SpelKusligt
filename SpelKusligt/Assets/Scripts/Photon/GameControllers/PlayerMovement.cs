﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private PhotonView pv;
    public float speed = 4.0f;
    public float gravity = -9.8f;

    private CharacterController _charCont;

    // Start is called before the first frame update
    void Start()
    {
        pv = GetComponent<PhotonView>();
        _charCont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pv.IsMine)
        {
            BasicMovement();
            //BasicRotation();
        }
    }

    void BasicMovement()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed); //Limits the max speed of the player

        // movement.y = gravity;

        movement *= Time.deltaTime;     //Ensures the speed the player moves does not change based on frame rate
        movement = transform.TransformDirection(movement);
        _charCont.Move(movement);
    }

   
}

 /*
    void BasicRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;
        transform.Rotate(new Vector3(0, mouseX, 0));
    }
    */
/* void start
        pv = GetComponent<PhotonView>();
        myCC = GetComponent<CharacterController>();
        */

/* basicmovement
        if (Input.GetKey(KeyCode.W))
        {
            myCC.Move(transform.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myCC.Move(-transform.right * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myCC.Move(-transform.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myCC.Move(transform.right * Time.deltaTime * movementSpeed);
        }
        */