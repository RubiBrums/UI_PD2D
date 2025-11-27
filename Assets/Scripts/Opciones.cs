using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Opciones : MonoBehaviour
{

    public TextMeshProUGUI textoResolucion;
    public TextMeshProUGUI nombreIdioma;

    public string[] nombreResolucion;
    public string[] idiomaNombre;


    public int resolucionNum = 0;
    public int idiomaNum = 0;


    void Start()
    {
        textoResolucion.text = nombreResolucion[resolucionNum];
        nombreIdioma.text = idiomaNombre[idiomaNum];

    }
    public void resDerecha()
    {
        resolucionNum ++;
        if(resolucionNum >= nombreResolucion.Length)
        {
            resolucionNum = 0;
        }
        textoResolucion.text = nombreResolucion[resolucionNum];
    }
    public void resIzquierda()
    {
        resolucionNum --;
        if(resolucionNum < 0)
        {
            resolucionNum = nombreResolucion.Length - 1;
        }
        textoResolucion.text = nombreResolucion[resolucionNum];
    }
        public void idiomaDerecha()
    {
        idiomaNum ++;
        if(idiomaNum >= idiomaNombre.Length)
        {
            idiomaNum = 0;
        }
        nombreIdioma.text = idiomaNombre[idiomaNum];
    }
    public void idiomaIzquierda()
    {
        idiomaNum --;
        if(idiomaNum < 0)
        {
            idiomaNum = idiomaNombre.Length - 1;
        }
        nombreIdioma.text = idiomaNombre[idiomaNum];
    }
}
