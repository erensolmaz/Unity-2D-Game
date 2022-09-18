using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHareket : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public Joystick joystick;
    public Rigidbody2D rb;
    public GameManager gameManager;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        horizontalMove = joystick.Horizontal * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        float verticalMove = joystick.Vertical;
        // if (Input.GetButtonDown("Jump"))
        if (verticalMove >= .5f)
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        //if (Input.GetButtonDown("Crouch"))
        if (verticalMove <= -.5f)
        {
            crouch = true;
        }
        else// if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }



    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);

    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        if (rb.position.y < -25f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
