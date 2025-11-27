using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuiInventario : MonoBehaviour
{
    public Image imagenGrande;
    public TMP_Text nombreTexto;
    public TMP_Text descripcionTexto;

    public void MostrarItem(items item)
    {
        nombreTexto.text = item.Nombre;
        descripcionTexto.text = item.Descripcion;

        if (item.sprite != null)
            imagenGrande.sprite = item.sprite;
    }
}
