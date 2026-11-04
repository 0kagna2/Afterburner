using UnityEngine;

public class Nave : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 7f;

    [Header("movimiento eje z")]
    public float velocidadZ = 5f;
    public Vector3 direccionZ = Vector3.forward;

    private float horizontalInput;
    private float verticalInput;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccionZ * velocidadZ * Time.deltaTime);
       
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * horizontalInput * velocidad * Time.fixedDeltaTime);
        transform.Translate(Vector3.up * verticalInput * velocidad * Time.fixedDeltaTime);
    }
}
