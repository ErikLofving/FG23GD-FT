using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] KeyScript key;
    [SerializeField] DoorScript door;

    public bool keyPickedUp;


    [Header("Player Attributes")]
    [SerializeField] private MainMenu menu;

    [SerializeField] private GameObject PlayerObject;

    private void Start()
    {
        keyPickedUp = false;
    }

    private void Update()
    {
        if (PlayerObject.transform.position.y < 10)
        {
            menu.LostGame();
        }
    }
}
