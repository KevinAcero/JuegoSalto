using UnityEngine;

public class AutoSalto : MonoBehaviour
{

    //Declaramos la variables y le asignamos un  valor predeterminado
    public float FuerzaSalto = 5f;
    public float TiempoSalto = 1.5f;

    private float Tiempo = 0f;
    private Rigidbody rb;
    private bool isGrounded = true;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        Saltar();
    }

    //Cuando se cumple el intervalo de tiempo invoca la funcion de saltar
    void Update()
    {
        Tiempo += Time.deltaTime;

        if (Tiempo >= TiempoSalto && isGrounded)
        {
            Saltar();
            Tiempo = 0f;
        }
    }
    //Realiza el salto cuando la función es invocada
    void Saltar()
    {
        rb.AddForce(Vector3.up * FuerzaSalto, ForceMode.Impulse);
        isGrounded = false;
    }

    //Detecta si el personaje esta en contacto con el suelo
    void OnCollisionEnter(Collision Choque)
    {
        if (Choque.gameObject.CompareTag("PISO"))
        {
            isGrounded = true;
        }
    }
}
