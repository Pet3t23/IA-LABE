using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f; // Velocidad configurable del proyectil
    public float lifeTime = 1f; // Tiempo de vida antes de destruirse

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed; // Aplica velocidad al proyectil
        Destroy(gameObject, lifeTime); // Destruir después de 1 segundo
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destructible"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
