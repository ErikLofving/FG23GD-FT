using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    //Enemy Health Values
    [SerializeField] private float enemyHealth = 100f;
    [SerializeField] private float currentHealth;

    //Enemy HealthBar
    [SerializeField] private Slider slider;
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 sliderOffset;

    private void Start()
    {
        currentHealth = enemyHealth;
    }

    void Update()
    {
        UpdateHealthBar();
        slider.transform.rotation = cam.transform.rotation;
        slider.transform.position = target.position + sliderOffset;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            currentHealth = currentHealth - 10f;
        }
    }

    public void UpdateHealthBar()
    {
        slider.value = currentHealth / enemyHealth;
    }

}
