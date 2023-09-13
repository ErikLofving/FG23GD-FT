using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] public Transform cam;

    public Rigidbody rb;

    [SerializeField] private int speed = 4;
    [SerializeField] private float jumpforce = 50;
    [SerializeField] private int rotationSpeed = 25;

    [SerializeField] private int jumpAmount;
    //[SerializeField] private bool isGrounded;

    private Vector3 playerinput;
    public Vector3 moveDirection;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Locks the cursor in the middle of the screen when clicked in the Game view
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        playerinput.x = Input.GetAxis("Horizontal");
        playerinput.y = Input.GetAxis("Vertical");

        HandleMovement();
    }

    private void FixedUpdate()
    {
        
        HandleRotation();
        
    }
    private void HandleMovement()
    {
        moveDirection = cam.forward * playerinput.y;
        moveDirection = moveDirection + cam.right * playerinput.x;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection = moveDirection * speed;

        Vector3 movementVelocity = new Vector3( moveDirection.x, rb.velocity.y, moveDirection.z);
        rb.velocity = movementVelocity;

        if (Input.GetButtonDown("Jump") && jumpAmount > 0)
        {
            jump();          
        }
    }

    private void HandleRotation()
    {
        Vector3 targetDirection = Vector3.zero;

        targetDirection = cam.forward * playerinput.y;
        targetDirection = moveDirection + cam.right * playerinput.x;
        targetDirection.Normalize();
        targetDirection.y = 0;  

        if (targetDirection == Vector3.zero)
        {
            targetDirection = transform.forward;
        }

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = playerRotation;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //isGrounded = true;
            jumpReset();
        }
        
    }
    /*private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }    
    }*/

    private int jumpReset()
    {
        return jumpAmount = 2;
    }

    private void jump()
    {
        rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        jumpAmount--;
    }
}
