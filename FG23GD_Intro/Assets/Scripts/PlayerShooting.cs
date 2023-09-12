using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnLocation;

    private bool isShooting = false;

    // Update is called once per frame
    private void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {
            isShooting = true;
            Debug.Log("Skjuter");
            spawnBullet();
        }
        else
        {
            isShooting = false;   
        }
    }

    private void spawnBullet()
    {
        Instantiate(bulletPrefab,bulletSpawnLocation.transform.position, Quaternion.identity);
    }

}
