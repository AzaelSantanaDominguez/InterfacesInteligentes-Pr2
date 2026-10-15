using UnityEngine;

public class Ej1 : MonoBehaviour
{
    public int daño;
    public float speed = 5f; // Velocidad de movimiento del objeto
    private Rigidbody rb; // Referencia al componente Rigidbody del objeto
    private float moveHorizontal; // Variable para almacenar el movimiento horizontal
    private float moveVertical; // Variable para almacenar el movimiento vertical

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = 0f;
        moveVertical = 0f;

        if (Input.GetKey(KeyCode.W)) moveVertical = 1f; // Mover hacia arriba
        if (Input.GetKey(KeyCode.S)) moveVertical = -1f; // Mover hacia abajo
        if (Input.GetKey(KeyCode.A)) moveHorizontal = -1f; // Mover hacia la izquierda
        if (Input.GetKey(KeyCode.D)) moveHorizontal = 1f; // Mover hacia la derecha
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); // Crear un vector de movimiento
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime); // Mover el objeto usando Rigidbody
    }
}
