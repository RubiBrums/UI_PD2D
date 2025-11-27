using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BotonesGUI : MonoBehaviour
{
    public GameObject menuInventario;
    public GameObject menuPausa;
    public GameObject guiGameplay;
    public GameObject menuOpciones;


    public bool inventarioAbierto = false;
    public bool juegoPausado = false;

    public void Update()
    {
        AbrirInventario();
        Pausa();
    }

    public void AbrirInventario()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventarioAbierto = !inventarioAbierto;
            menuInventario.SetActive(inventarioAbierto);
            
        }
    }
    public void Pausa()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuOpciones.activeSelf)
            {
                menuOpciones.SetActive(false);
                menuPausa.SetActive(true);
                return;
            }
            juegoPausado = !juegoPausado;
            menuPausa.SetActive(juegoPausado);
            guiGameplay.SetActive(!juegoPausado);
            Time.timeScale = juegoPausado ? 0 : 1;
        }
    }

    public void Continuar()
    {
        juegoPausado = false;
        menuPausa.SetActive(false);
        guiGameplay.SetActive(true);
        Time.timeScale = 1;
    }

    public void Opciones()
    {
        menuOpciones.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Volver()
    {
        menuOpciones.SetActive(false);
        menuPausa.SetActive(true);
    }
}
