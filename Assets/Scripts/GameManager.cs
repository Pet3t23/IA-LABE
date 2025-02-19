using UnityEngine; // Asegúrate de que esto esté al principio

public class GameManager : MonoBehaviour
{
    public int keyCount = 0;

    public void AddKeyToInventory()
    {
        keyCount++;
        Debug.Log("Llave recogida. Total de llaves: " + keyCount);
    }
}
