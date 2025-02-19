using UnityEngine;

public class Door : MonoBehaviour
{
    public void OpenDoor()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && InventoryManager.instance.HasKey())
        {
            InventoryManager.instance.UseKey();
            OpenDoor();
        }
    }
}
