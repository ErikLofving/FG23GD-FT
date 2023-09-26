using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    [SerializeField] GameObject[] waypoints;

    private int currentWaypointIndex = 0;

    [SerializeField] private bool isEnemy;

    [SerializeField] float wayPointSpeed = 1f;

    [SerializeField] Movement movement;


    [Header("Platform")]
    [SerializeField] private Transform platformTransform;
    [SerializeField] private Transform playerTransform;

    void Update()
    {

        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }

            if (isEnemy)
            {
                transform.rotation = waypoints[currentWaypointIndex].transform.rotation;
            }

        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, wayPointSpeed * Time.deltaTime);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            movement.jumpReset();
            playerTransform.parent = platformTransform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {

            playerTransform.parent = null;

        }
    }

}