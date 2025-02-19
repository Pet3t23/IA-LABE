using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    private int keys = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddKey()
    {
        keys++;
    }

    public bool HasKey()
    {
        return keys > 0;
    }

    public void UseKey()
    {
        if (keys > 0) keys--;
    }
}
