using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStateDriven : MonoBehaviour
{
    public float moveSpeed = 1;
    public float rotationSpeed = 1;

    private Animator animator;
    private Rigidbody rb;
    private new Camera camera;

    private bool canMove = true;
    private float rotate;
    private float movement;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        camera = FindObjectOfType<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal") && !Input.GetButton("Vertical"))
        {
            movement = moveSpeed * Time.deltaTime;
        }
        else
        {
            movement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            if (movement < 0)
            {
                movement = 0;
            }
        }

        rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;


        MoveAnimation(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.G) && canMove)
        {
            animator.SetTrigger("DrawGun");
            canMove = false;
        }

        if (Input.GetKeyDown(KeyCode.P) && canMove)
        {
            animator.SetTrigger("PressAir");
            canMove = false;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("StillJump");
            canMove = false;
        }
    }

    private void MoveAnimation(float movement, float rotate)
    {
        if (movement < 0)
        {
            movement = 0;
        }

        animator.SetFloat("InputZ", movement);
        animator.SetFloat("InputY", rotate);
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            // Convert Y rotation to Quaternion
            Vector3 yRot = new Vector3(0, rotate, 0);
            Quaternion newRot = Quaternion.Euler(yRot);

            // Add new rotation to current rotation
            rb.MoveRotation(rb.rotation * newRot);

            // Multiply movement with rotation to move same direction where player looks
            Vector3 move = new Vector3(0, 0, movement);
            move = Quaternion.Euler(rb.rotation.eulerAngles) * move;

            // Add movement to current position
            rb.MovePosition(rb.transform.position + move);
        }
    }

    public void CanMove()
    {
        canMove = true;
    }

}
