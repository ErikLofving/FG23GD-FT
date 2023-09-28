using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSpawn : MonoBehaviour
{
    

    [SerializeField] GameObject explosionToSpawn;

    public void SpawnExplosion()
    {
        Instantiate(explosionToSpawn, transform.position, Quaternion.identity);
    }


}


