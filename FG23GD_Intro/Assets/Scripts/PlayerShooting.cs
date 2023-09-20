using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPrefab2;

    [SerializeField] private Transform bulletSpawnLocation;


    private float randomBullet;

    // Update is called once per frame
    private void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {

            randomBullet = Random.Range(1, 100);

            if (randomBullet <= 50)

            //Debug.Log("Skjuter");
            spawnBullet1();
            else
            {
                spawnBullet2();
            }
        }
        

    }
    private void spawnBullet1()
    {
        Instantiate(bulletPrefab,bulletSpawnLocation.transform.position, transform.rotation);
    }
    private void spawnBullet2()
    {
        Instantiate(bulletPrefab2, bulletSpawnLocation.transform.position, transform.rotation);
    }

}
