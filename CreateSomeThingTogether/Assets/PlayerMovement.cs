using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public CharacterController2D controller;
    float horizontalMove;
    public float runSpeed = 40f;
    private bool jump = false; //dont show on the inspector

    
    void Update()
    {
       horizontalMove =  Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true; 
        }      
    }
    
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false, jump );
        jump = false;
    }
}
