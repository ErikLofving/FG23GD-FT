using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerKnockBack : MonoBehaviour
{

    [SerializeField] Rigidbody rb;

    [SerializeField] private int knockBackForce;

    Movement movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            rb.velocity = rb.velocity + new Vector3(-movement.moveDirection.x * 10, rb.velocity.y, -movement.moveDirection.z * 10);
        }
    }

}
