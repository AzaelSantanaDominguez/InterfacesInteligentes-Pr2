using UnityEngine;

public class Ej3Daño : MonoBehaviour
{   
    private void OnTriggerEnter(Collider collider) {
        Ej1 ej1 = collider.GetComponent<Ej1>();
        if (ej1 != null) {
            ej1.daño += 10; // Incrementar el daño en 10
            Debug.Log("Daño incrementado a: " + ej1.daño);
        }
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
