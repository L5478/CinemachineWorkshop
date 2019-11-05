using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFreeLook : MonoBehaviour
{
    float x;
    float z;
    public float speed = 1;
    public float rotationSpeed = 1;

    Animator animator;
    Rigidbody rb;
    new Camera camera;
    

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
        x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, camera.transform.rotation.eulerAngles.y, 0), rotationSpeed * Time.deltaTime);
        }
    }

    private void Move(float xMove, float zMove)
    {
        animator.SetFloat("InputZ", zMove);
        animator.SetFloat("InputX", xMove);
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3(x, 0, z);
        move = Quaternion.Euler(rb.rotation.eulerAngles) * move;
        rb.MovePosition(rb.position + move);
    }
}
