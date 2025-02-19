using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject projectilePrefab;
    public Transform firePoint;
    public Key key; // Referencia a la llave (si decides gestionarlo desde el jugador)

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * speed * Time.deltaTime);

        // Si presiona "E" para recoger la llave (o cualquier otra tecla)
        if (Input.GetKeyDown(KeyCode.E) && key != null && !key.isPickedUp)
        {
            key.PickupKey();
        }

        if (Input.GetMouseButtonDown(0)) // Click izquierdo para disparar
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
