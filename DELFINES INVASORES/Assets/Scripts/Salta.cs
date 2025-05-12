using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Salta : MonoBehaviour
{
    //Declaramos la variables y le asignamos un  valor predeterminado
    public float Salto = 4f;
    public LayerMask CapaPiso;
    public Transform ObjetoNulo;
    public float RadioObjetoNulo = 0.3f;

    private Rigidbody rb;
    private bool isGrounded;
    private Animator Animacion;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Animacion = GetComponent<Animator>();
    }

    void Update()
    {
        // Revisamos si el personaje esta tocando el suelo
        isGrounded = Physics.CheckSphere(ObjetoNulo.position, RadioObjetoNulo, CapaPiso);

        Animacion.SetBool("Salto", !isGrounded);

        // Salta solo si precionamos tecla espacio y está en el suelo
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, Salto, rb.linearVelocity.z);
        }
        rb.freezeRotation = true;
    }

    // Mostramos el radio del "RadioObjetoNulo" para revisar cuando toca el suelo
    void OnDrawGizmosSelected()
    {
        if (ObjetoNulo != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(ObjetoNulo.position, RadioObjetoNulo);
        }
    }

}
