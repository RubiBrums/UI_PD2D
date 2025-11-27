using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioEscena : MonoBehaviour
{
    public string nombreEscena;
    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
