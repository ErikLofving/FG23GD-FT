using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnLocation;

    // Update is called once per frame
    private void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {

            Debug.Log("Skjuter");
            spawnBullet();
        }

    }
    private void spawnBullet()
    {
        Instantiate(bulletPrefab,bulletSpawnLocation.transform.position, transform.rotation);
    }

}
