using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StabStab : MonoBehaviour
{

    [SerializeField ]EnemyScript health;

    [SerializeField] private NavMeshAgent enemyNavmesh;

    private float StabStabHealth;
    private bool isHealing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StabStabHealth = health.currentHealth;
        
        if (StabStabHealth == 0f)
        {
            isHealing = true;
        }
        else
        {
            isHealing = false;
        }


        if (isHealing)
        {
            WaitToHeal();
            health.currentHealth = health.enemyHealth;
        }


    }


    private void WaitToHeal()
    {      
            enemyNavmesh.enabled = false;
            StartCoroutine(WaitingTime());
    }

    IEnumerator WaitingTime()
    {

        yield return new WaitForSeconds(5);
        enemyNavmesh.enabled = true;
        
        Debug.Log("Healed");

    }

}
