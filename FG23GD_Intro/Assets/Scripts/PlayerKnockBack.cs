using UnityEngine;

public class PlayerKnockBack : MonoBehaviour
{

    [SerializeField] Rigidbody rb;

    [SerializeField] private int knockBackForce;

    Movement movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            rb.AddForce(rb.velocity * -1 * knockBackForce, ForceMode.Impulse); 

            Debug.Log("KnockingBack");
        }
    }

}
