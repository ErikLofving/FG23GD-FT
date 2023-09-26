using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    [SerializeField] private float characterMaxHealth = 100f;
    [SerializeField] public float characterCurrentHealth;

    [SerializeField] private Image HealthBarImage;

    [SerializeField] Rigidbody rb;

    [SerializeField] private float knockBackForce;
    [SerializeField] private float knockBackTime;

    [SerializeField] private Movement movement;

    private float lerpSpeed;

    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterCurrentHealth = characterMaxHealth;
    }

    private void Update()
    {

        lerpSpeed = 3f * Time.deltaTime;

        UpdateHealthBar();
        colorChange();

        if (characterCurrentHealth > characterMaxHealth)
        {
            characterCurrentHealth = characterMaxHealth;

            
        }

        if (characterCurrentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Cursor.lockState = CursorLockMode.None;
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
        HealthBarImage.fillAmount = Mathf.Lerp(HealthBarImage.fillAmount, (characterCurrentHealth / characterMaxHealth), lerpSpeed);
    }

    private void colorChange()
    {
        Color healthColor = Color.Lerp(Color.red, Color.green, (characterCurrentHealth/characterMaxHealth));

        HealthBarImage.color = healthColor;

    }


    private IEnumerator DisableKnockBack()
    {
        rb.AddForce(new Vector3(-movement.moveDirection.x * knockBackForce, movement.moveDirection.y, -movement.moveDirection.z * knockBackForce), ForceMode.Impulse);
        yield return new WaitForSeconds(knockBackTime);
        movement.canMove = true;
    }


}
