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

    // Cambiar el m�todo a p�blico
    public void PickupKey() // M�todo p�blico
    {
        isPickedUp = true; // Marca la llave como recogida
        gameManager.AddKeyToInventory(); // Si tienes un GameManager que maneja el inventario, agrega la llave aqu�.

        // Destruir la llave (hacerla desaparecer)
        Destroy(gameObject);
    }
}
