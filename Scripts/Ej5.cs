using UnityEngine;

public class Ej5 : MonoBehaviour
{   
    public float speed = 100f; // Velocidad de movimiento del objeto
    private Rigidbody rb; // Referencia al componente Rigidbody del objeto
    public bool move = false; // Variable para controlar el movimiento del objeto
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X)) move = true; // Activar el movimiento al presionar la tecla X
    }

    void FixedUpdate()
    {
        if (move)
        {
            Vector3 movement = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f)); // Crear un vector de movimiento hacia adelante
            rb.AddForce(movement * speed * Time.fixedDeltaTime, ForceMode.VelocityChange); // Mover el objeto usando Rigidbody
            move = false; // Desactivar el movimiento después de mover el objeto
        }
    }
}
