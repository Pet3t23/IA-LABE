using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Jugador
    public Vector3 offset = new Vector3(0, 15, 0); // Altura de la cámara
    public float smoothSpeed = 10f; // Suavidad del seguimiento

    void LateUpdate()
    {
        if (target == null) return;

        // La cámara sigue al jugador manteniendo la misma altura
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Asegurar que la cámara siempre mire hacia abajo sin rotación extraña
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
