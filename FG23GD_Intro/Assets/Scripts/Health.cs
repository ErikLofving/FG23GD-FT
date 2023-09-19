using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    [SerializeField] private float characterMaxHealth = 100f;
    [SerializeField] public float characterCurrentHealth;

    [SerializeField] private Slider slider;

    [SerializeField] Rigidbody rb;

    [SerializeField] private float knockBackForce;
    [SerializeField] private float knockBackTime;

    [SerializeField] private Movement movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterCurrentHealth = characterMaxHealth;
    }

    private void Update()
    {
        UpdateHealthBar();

        if (characterCurrentHealth > characterMaxHealth)
        {
            characterCurrentHealth = characterMaxHealth;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Hammer")
        {
            movement.canMove = false;
            characterCurrentHealth = characterCurrentHealth - 10f;

            
            Debug.Log("KnockingBack");
            

            StartCoroutine(DisableKnockBack());
            
        }
        
        
    }

    public void UpdateHealthBar()
    {
        slider.value = characterCurrentHealth / characterMaxHealth;
    }


    private IEnumerator DisableKnockBack()
    {
        rb.AddForce(new Vector3(-movement.moveDirection.x * knockBackForce, movement.moveDirection.y, -movement.moveDirection.z * knockBackForce), ForceMode.Impulse);
        yield return new WaitForSeconds(knockBackTime);
        movement.canMove = true;
    }


}
