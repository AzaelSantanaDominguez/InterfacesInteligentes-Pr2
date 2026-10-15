using UnityEngine;

public class Ej2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        Renderer rend = collider.GetComponent<Renderer>();
        if (rend != null) rend.material.color = new Color(Random.value, Random.value, Random.value);
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
