using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{

    public string NombreItem;
    [SerializeField] private TextMeshProUGUI Nombre;
    [SerializeField] private TextMeshProUGUI Descripcion;
    public Sprite spriteItem1;
    public Sprite spriteItem2;
    public Sprite spriteItem3;
    public Sprite spriteItem4;
    public Sprite spriteItem5;
    public Sprite spriteItem6;
    public Sprite spriteItem7;
    public Sprite spriteItem8;
    public Sprite spriteItem9;
    public Sprite spriteItem10;
    public Sprite spriteItem11;
    public Sprite spriteItem12;
    public Sprite spriteItem13;
    public Sprite spriteItem14;
    public Sprite spriteItem15;
    public Sprite spriteItem16;
    public Sprite spriteItem17;
    public Sprite spriteItem18;
    public GameObject botonUsar;

    [SerializeField] private Image imagenItem;
    [SerializeField] private AudioSource seleccionar;

    void Start()
    {

    }

    public void SeleccionarItem(string nombreItem)
    {
        NombreItem = nombreItem;
        //seleccionar.Play();
        botonUsar.SetActive(true);
        switch (NombreItem)
        {
            case "boina":
                SetData("Boina de ilustradora",
                    "Una boina robada de una ilustradora que luchaba contra robots, es bastante cómoda e inspira creatividad.",spriteItem15);
                break;

            case "granja":
                SetData("Sombrero de paja",
                    "Sombrero robado de la granjera Maggie, es bueno para protegerse del sol.",spriteItem4);
                break;

            case "arroz":
                SetData("Sombrero de arroz",
                    "Un sombrero de arroz, solo eso. Se ve bien. Aunque el de Charlie es mejor.",spriteItem1);
                break;

            case "g_escurridizo":
                SetData("Gusano Escurridizo",
                    "Un escurridizo y picante gusano que aumenta la velocidad por 4 segundos.",spriteItem13);
                break;

            case "g_musculoso":
                SetData("Gusano Musculoso",
                    "Un gigante y musculoso gusano que aumenta la fuerza por 4 segundos.",spriteItem12);
                break;

            case "g_legendario":
                SetData("Gusano Legendario",
                    "Un reluciente y poderoso gusano con propiedades curativas y potenciadoras. Añade un corazón adicional en el HP y recupera toda la salud.",spriteItem17);
                break;

            case "g_saludable":
                SetData("Gusano Saludable",
                    "Un rosado y delicioso gusano con propiedades curativas. Recupera +1 HP.",spriteItem16);
                break;

            case "camionero":
                SetData("Gorra de camionero",
                    "Una gorra encontrada en la parada de camiones. Tiene manchas de aceite y huele a cigarrillos.",spriteItem2);
                break;

            case "cofia":
                SetData("Cofia",
                    "Una cofia sucia y asquerosa encontrada en la basura de un matadero.",spriteItem18);
                break;

            case "panoleta":
                SetData("Pañoleta",
                    "Una linda pañoleta con puntos, robada de la granjera Maggie.",spriteItem5);
                break;

            case "halloween":
                SetData("Sombrero de bruja",
                    "Sombrero temático para Halloween.",spriteItem7);
                break;

            case "navidad":
                SetData("Gorro de navidad",
                    "Gorro temático para Navidad.",spriteItem3);
                break;

            case "e_oxidada":
                SetData("Espuelas oxidadas",
                    "Viejas espuelas encontradas en la basura. El riesgo de contraer tétanos para el enemigo es bajo, pero nunca nulo.",spriteItem10);
                break;

            case "e_ornamental":
                SetData("Espuelas ornamentales",
                    "Elegantes espuelas doradas encontradas en una parada de camiones. Transmiten lujo y ciegan a sus enemigos con su brillo.",spriteItem9);
                break;

            case "e_acero":
                SetData("Espuelas de acero inoxidable",
                    "Resistentes y filosas. Estas espuelas encontradas en un matadero pueden cortar hasta el metal.",spriteItem8);
                break;

            case "e_cobre":
                SetData("Espuelas de cobre",
                    "Pulidas pero algo débiles. Son levemente mejores a las espuelas oxidadas, ya que podrás atacar más rápido.",spriteItem11);
                break;

            case "lentes":
                SetData("Lentes de sol",
                    "Los lentes de una empresaria malvada. Son costosos, pero me los robé, así que son más baratos.", spriteItem6);
                break;

            case "larva":
                SetData("Larva",
                    "Pequeña larva curativa, pero no tan buena en ello, cura +0.5 HP.",spriteItem14);
                break;
        }
    }

    public void SetData(string nombre, string descripcion, Sprite nombreSprite)
    {
        Nombre.text = nombre;
        Descripcion.text = descripcion;
        imagenItem.sprite = nombreSprite;
    }
    
}
