using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class MakeChildOf : MonoBehaviour
{

    [Header("Platform")]
    [SerializeField] private Transform platformTransform;
    [SerializeField] private Transform playerTransform;

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            playerTransform.parent = platformTransform;
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerTransform.parent = null;
        }
    }

}
