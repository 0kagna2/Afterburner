using UnityEngine;

public class CamaraSigue : MonoBehaviour
{
    public Transform objetivo; // El objeto que la cámara seguirá
    public Vector3 desplazamiento = new Vector3(0, 0, -10); // Desplazamiento de la cámara respecto al objetivo

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void LateUpdate()
    {
        if (objetivo != null)
        {
            // Actualiza la posición de la cámara para seguir al objetivo con el desplazamiento
            transform.position = objetivo.position + desplazamiento;
        }
    }
    // Update is called once per frame
    void Update()
    {
           
    }
}
