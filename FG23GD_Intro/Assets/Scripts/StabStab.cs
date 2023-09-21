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

        if (health.currentHealth <= 0.0f && !isHealing)
        {
            DisableNavmesh();
            StartCoroutine(WaitingTime());
        }

    }

    private void DisableNavmesh()
    {
            
            enemyNavmesh.enabled = false;
            
    }

    private IEnumerator WaitingTime()
    {
        isHealing = true;
        while (StabStabHealth < health.enemyHealth)
        {

            health.currentHealth++;
            yield return new WaitForSeconds(0.1f);
            
        }

        enemyNavmesh.enabled = true;
        isHealing = false;

    }

    public IEnumerator attackedPlayer()
    {
        yield return new WaitForSeconds(1);
        enemyNavmesh.enabled = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //DisableNavmesh();
            //StartCoroutine(attackedPlayer());
            
            Debug.Log("LOL");
        }
    }

}
