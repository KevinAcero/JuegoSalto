using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaDeFinJuego : MonoBehaviour
{
    public string EscenaInicio = "PantallaInicio";

    void Update()
    {
        // Si el jugado oprime la tecla espacio se cargará la escena del juego
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log("Cargando escena: " + EscenaInicio);
            SceneManager.LoadScene(EscenaInicio);
        }
    }
}
