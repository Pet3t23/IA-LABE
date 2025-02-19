using UnityEngine;
using System.Collections; // <-- Agregar esta línea

public class NonDestructibleObstacle : MonoBehaviour
{
    public int health = 3;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void TakeDamage()
    {
        health--;
        StartCoroutine(FlashRed());

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator FlashRed()
    {
        rend.material.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        rend.material.color = Color.white;
    }
}
