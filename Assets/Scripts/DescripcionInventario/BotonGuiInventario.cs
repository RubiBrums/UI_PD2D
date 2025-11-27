using UnityEngine;
using UnityEngine.UI;

public class BotonGuiInventario : MonoBehaviour
{
    public Image icono;
    items miItem;
    GuiInventario ui;

    public void Crear(items data, GuiInventario uiDestino)
    {
        miItem = data;
        ui = uiDestino;
        if (data.sprite != null)
            icono.sprite = data.sprite;
    }

    public void AlPresionar()
    {
        ui.MostrarItem(miItem);
    }
}