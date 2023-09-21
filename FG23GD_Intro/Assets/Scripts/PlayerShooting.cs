using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPrefab2;
    [SerializeField] private GameObject bulletPrefab3;
    [SerializeField] private GameObject bulletPrefab4;

    [SerializeField] private Transform bulletSpawnLocation;


    private float randomBullet;

    // Update is called once per frame
    private void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {

            randomBullet = Random.Range(1, 200);

            if (randomBullet <= 50)

            //Debug.Log("Skjuter");
            spawnBullet1();
            else if (randomBullet > 50 && randomBullet <= 100)
            {
                spawnBullet2();
            }
            else if (randomBullet > 101 && randomBullet <= 150)
            {
                spawnBullet3();
            }
            else if (randomBullet > 151 && randomBullet <= 200)
            {
                spawnBullet4();
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
    private void spawnBullet3()
    {
        Instantiate(bulletPrefab3, bulletSpawnLocation.transform.position, transform.rotation);
    }
    private void spawnBullet4()
    {
        Instantiate(bulletPrefab4, bulletSpawnLocation.transform.position, transform.rotation);
    }


}
