using System.Diagnostics;
using UnityEngine;

public class MuerteToqueCuerda : MonoBehaviour
{

    private Animator Animacion;
    private bool Muerte = false;
    private Rigidbody rb;

    void Start()
    {
        Animacion = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    //Detecta cuando hay una colici�n entre el personaje y la cuerda y reproduce la animaci�n de muerte
    private void OnCollisionEnter(Collision Choque)
    {
        if (Muerte) return;

        if (Choque.gameObject.CompareTag("CUERDA"))
        {
            Muerte = true;
            Animacion.Play("Death");
            UnityEngine.Debug.Log("NOOOOO SE MURIO");
        }
        
        UnityEngine.Debug.Log("ME ESTAS TOCANDO AAAA...");
    }
}
