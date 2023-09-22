using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] KeyScript key;
    [SerializeField] DoorScript door;

    public bool keyPickedUp;

    private void Start()
    {
        keyPickedUp = false;
    }


}
