using UnityEngine; // Aseg�rate de que esto est� al principio

public class GameManager : MonoBehaviour
{
    public int keyCount = 0;

    public void AddKeyToInventory()
    {
        keyCount++;
        Debug.Log("Llave recogida. Total de llaves: " + keyCount);
    }
}
