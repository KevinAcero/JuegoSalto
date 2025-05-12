using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoqueCuerda : MonoBehaviour
{
    public string nombreEscenaGameOver = "GAME_OVER";

    private void OnCollisionEnter(Collision collision)
    {
        // Si deseas que solo ciertos objetos causen Game Over, usa:
        if (collision.gameObject.CompareTag("CUERDA"))
        {
            UnityEngine.Debug.Log("Colisión detectada. Cargando escena de Game Over...");
            SceneManager.LoadScene(nombreEscenaGameOver);
        }
    }
}
