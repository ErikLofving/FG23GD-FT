using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private float characterHealth = 100f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            characterHealth = characterHealth - 10f;
            
        }
    }

}
