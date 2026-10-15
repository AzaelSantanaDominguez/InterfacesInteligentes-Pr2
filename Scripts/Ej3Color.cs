using UnityEngine;

public class Ej3 : MonoBehaviour
{
    private Color colorOriginal; // Variable para almacenar el color original del objeto
    private Color colorColision = Color.green; // Variable para almacenar el color del objeto al colisionar

    private void OnTriggerEnter(Collider other)
    {   
        colorOriginal = other.GetComponent<Renderer>().material.color; // Guardar el color original del objeto
        Renderer rend = other.GetComponent<Renderer>();
        if (rend != null) rend.material.color = colorColision; // Cambiar el color del objeto al colisionar
    }

    private void OnTriggerExit(Collider other)
    {
        Renderer rend = other.GetComponent<Renderer>();
        if (rend != null) rend.material.color = colorOriginal; // Restaurar el color original del objeto al salir de la colisión
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
