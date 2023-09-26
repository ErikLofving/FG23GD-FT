using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab0;
    [SerializeField] private GameObject bulletPrefab1;
    [SerializeField] private GameObject bulletPrefab2;
    [SerializeField] private GameObject bulletPrefab3;
    [SerializeField] private GameObject bulletPrefab4;

    [SerializeField] private Transform bulletSpawnLocation;

    


    private float randomBullet;

    private void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {

            spawnBullet0();

            Cursor.lockState = CursorLockMode.Locked;

            /*randomBullet = Random.Range(1, 200);

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
            }*/


        }
        

    }
    private void spawnBullet0()
    {
        Instantiate(bulletPrefab0, bulletSpawnLocation.transform.position, transform.rotation);
    }
    private void spawnBullet1()
    {
        Instantiate(bulletPrefab1,bulletSpawnLocation.transform.position, transform.rotation);
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
