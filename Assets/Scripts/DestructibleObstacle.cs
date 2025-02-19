using UnityEngine;

public class DestructibleObstacle : MonoBehaviour
{
    public void TakeDamage()
    {
        Destroy(gameObject);
    }
}
