using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    Movement movement;
    Rigidbody rb;

    [SerializeField] private float bulletSpeed = 20f;

    // Start is called before the first frame update
    private void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.AddForce(movement.moveDirection * bulletSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }


}
