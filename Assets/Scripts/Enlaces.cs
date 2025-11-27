using UnityEngine;

public class Enlaces : MonoBehaviour
{
    public void AbrirEnlace(string URL)
    {
        Application.OpenURL(URL);
    }

}
