using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    //Enemy Health Values
    [SerializeField] public float enemyHealth = 100f;
    [SerializeField] public float currentHealth;

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

        //Changes Sliders Rotation to be the same as the camera rotation so that it always faces the camera
        slider.transform.rotation = cam.transform.rotation;
        slider.transform.position = target.position + sliderOffset;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            HitByBullet();
        }
        if (collision.gameObject.tag == "Player")
        {
            Vector3 hitPoint = collision.contacts[0].point;

            var knocbackDir = transform.position - hitPoint;
            knocbackDir.Normalize();
        }
    }

    private void HitByBullet()
    {
        currentHealth = currentHealth - 20f;


        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void UpdateHealthBar()
    {
        slider.value = currentHealth / enemyHealth;
    }

}
