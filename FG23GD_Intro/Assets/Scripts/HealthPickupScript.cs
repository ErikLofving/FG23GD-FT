using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupScript : MonoBehaviour
{

    [SerializeField] private Health playerHealth;

    [SerializeField] private float RespawnTime;

    private MeshRenderer meshRenderer;
    private Collider boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();    
        boxCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Destroy(gameObject);
            meshRenderer.enabled = false;
            boxCollider.enabled = false;

            StartCoroutine(Respawn());

            playerHealth.characterCurrentHealth = playerHealth.characterCurrentHealth + 10;

        }
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(RespawnTime);
        meshRenderer.enabled = true;
        boxCollider.enabled = true;

        //Debug.Log("Repspawnar!");

    }



}
