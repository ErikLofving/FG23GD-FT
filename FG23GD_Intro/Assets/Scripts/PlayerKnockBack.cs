using UnityEngine;

public class PlayerKnockBack : MonoBehaviour
{
    Movement movement;

    [SerializeField] Rigidbody rb;

    [SerializeField] private int knockBackForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            rb.AddForce(new Vector3(movement.moveDirection.x * -100, 0, 0), ForceMode.Impulse); 

            Debug.Log("KnockingBack");
        }
    }

}
