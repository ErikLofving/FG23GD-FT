using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathScript : MonoBehaviour
{

    private EnemyScript enemyScript;

    [SerializeField] private GameObject enemyExplosion;

    void Start()
    {
        enemyScript = GetComponent<EnemyScript>();
    }

    
    void Update()
    {
        if (enemyScript.currentHealth <= 0) 
        {
            Instantiate(enemyExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
