using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Cronometro : MonoBehaviour
{
    public float tiempoRestante = 30f;
    public string EscenaWin = "EscenaWin";

    public UnityEngine.UI.Text textoTiempo;

    void Update()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;

            if (textoTiempo != null)
            {
                textoTiempo.text = Mathf.CeilToInt(tiempoRestante).ToString();
            }
        }
        else
        {
            tiempoRestante = 0;
            SceneManager.LoadScene(EscenaWin);
        }
    }
}
