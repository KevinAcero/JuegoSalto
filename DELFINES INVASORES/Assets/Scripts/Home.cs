using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaInicio : MonoBehaviour
{
    public string EscenaJuego = "VIDEOJUEGO_JUMP";

    void Update()
    {
        // Si el jugador oprime la tecla espacio se cargará la escena del juego
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log("Cargando escena: " + EscenaJuego);
            SceneManager.LoadScene(EscenaJuego);
        }
    }
}