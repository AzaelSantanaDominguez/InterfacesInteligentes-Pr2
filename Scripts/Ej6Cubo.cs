using UnityEngine;

public class Ej6Cubo : MonoBehaviour
{   
    GameObject esfera; // Referencia al objeto esfera
    private bool tocando = false; // Variable para controlar si el cubo está tocando la esfera
    
    private void OnCollisionEnter(Collision collision)
    {
        Renderer esferaRenderer = esfera.GetComponent<Renderer>(); // Obtener el componente Renderer de la esfera
        esferaRenderer.material.color = new Color(Random.value, Random.value, Random.value); // Cambiar el color de la esfera al colisionar con el cubo
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        esfera = GameObject.FindWithTag("startPos");
    }

    // Update is called once per frame
    void Update()
    {
        Collider cuboCollider = GetComponent<Collider>();
        Collider esferaCollider = esfera.GetComponent<Collider>();

        bool contacto = Physics.ComputePenetration(
            cuboCollider, transform.position, transform.rotation,
            esferaCollider, esfera.transform.position,
            esfera.transform.rotation,
            out Vector3 direccion, out float distancia
        );

         if (contacto && !tocando)
        {
            Renderer esferaRenderer = esfera.GetComponent<Renderer>();

            if (esferaRenderer != null)
            {
                esferaRenderer.material.color = new Color(
                    Random.value,
                    Random.value,
                    Random.value
                );
            }
        }
        tocando = contacto;
    }
}
