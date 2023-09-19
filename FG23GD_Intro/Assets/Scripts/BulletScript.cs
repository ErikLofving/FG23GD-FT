using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    Rigidbody rb;
   

    [SerializeField] private float bulletSpeed = 20f;

    // Start is called before the first frame update
    private void Start()
    {
       
       rb = GetComponent<Rigidbody>();
       rb.AddRelativeForce(Vector3.forward * bulletSpeed, ForceMode.Impulse);
        transform.rotation = Random.rotation;
    }

    private void Update()
    {

        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
           
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Ground")
        {

            Destroy(gameObject);
        }
    }

   

}
