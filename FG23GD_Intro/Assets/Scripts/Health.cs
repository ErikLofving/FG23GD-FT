using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    [SerializeField] private float characterMaxHealth = 100f;
    [SerializeField] private float characterCurrentHealth;

    [SerializeField] private Slider slider;

    private void Start()
    {
        characterCurrentHealth = characterMaxHealth;
    }

    private void Update()
    {
        UpdateHealthBar();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            characterCurrentHealth = characterCurrentHealth - 10f; 
        }
    }

    public void UpdateHealthBar()
    {
        slider.value = characterCurrentHealth / characterMaxHealth;
    }

}
