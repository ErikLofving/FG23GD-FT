using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    Rigidbody rb;
   

    [SerializeField] private float bulletSpeed = 20f;

    private ExplosionSpawn explosionSpawn;

    // Start is called before the first frame update
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("ShootingSound");
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * bulletSpeed, ForceMode.Impulse);
        transform.rotation = Random.rotation;

        Destroy(this.gameObject, 10);

        explosionSpawn = GetComponent<ExplosionSpawn>();
    }

    




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            explosionSpawn.SpawnExplosion();
            Destroy(gameObject);
            
        }

        if (collision.gameObject.tag == "Ground")
        {
            explosionSpawn.SpawnExplosion();
            Destroy(gameObject);
            
        }
    }

   

}
