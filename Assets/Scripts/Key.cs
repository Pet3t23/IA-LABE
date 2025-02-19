using UnityEngine;

public class Key : MonoBehaviour
{
    public GameManager gameManager; // Referencia al GameManager para manejar el inventario
    public bool isPickedUp = false; // Para verificar si la llave ya fue recogida

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPickedUp) // Si el jugador colisiona con la llave
        {
            PickupKey();
        }
    }

    // Cambiar el método a público
    public void PickupKey() // Método público
    {
        isPickedUp = true; // Marca la llave como recogida
        gameManager.AddKeyToInventory(); // Si tienes un GameManager que maneja el inventario, agrega la llave aquí.

        // Destruir la llave (hacerla desaparecer)
        Destroy(gameObject);
    }
}
