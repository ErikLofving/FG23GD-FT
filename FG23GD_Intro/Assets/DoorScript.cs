using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    [SerializeField] private GameManager manager;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.keyPickedUp == true)
        {
            transform.position = transform.position + new Vector3(-1, 0, 0) * Time.deltaTime;

            if (transform.position.x < -1.5)
            {
                manager.keyPickedUp = false;
            }

        }
        


    }
}
