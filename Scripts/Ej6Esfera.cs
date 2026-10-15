using UnityEngine;

public class Ej6Esfera : MonoBehaviour
{
    private Transform endPos;
    private float speed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endPos = GameObject.FindWithTag("endPos").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (endPos != null) transform.position = Vector3.MoveTowards(transform.position, endPos.position, speed * Time.deltaTime);

    }
}
