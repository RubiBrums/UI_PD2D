using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{

    public string NombreItem;
    [SerializeField] private TextMeshProUGUI Nombre;
    [SerializeField] private TextMeshProUGUI Descripcion;
    [SerializeField] private TextMeshProUGUI DineroDisponible;
    [SerializeField] private TextMeshProUGUI AhorroDisponible;

    [SerializeField] private TextMeshProUGUI Precio;
    [SerializeField] private Image imagenItem;
    public Sprite spriteItem;
    private Image spriteBoton;
    [SerializeField] private Sprite agotado;
    private int dinero = 200;
    private int cantidad;
    private int ahorro = 5;
    private int ahorroDinero = 100;


    private int valor;
    [SerializeField] private AudioSource insuficiente;
    [SerializeField] private AudioSource comprado;
    [SerializeField] private AudioSource seleccionar;
    [SerializeField] private Animator charlie;
    [SerializeField] private Animator ranaRadio;
    [SerializeField] private AudioSource music;



    void Start()
    {
        DineroDisponible.text = dinero.ToString();
    }

    public void SeleccionarItem(string nombreItem)
    {
        NombreItem = nombreItem;
        spriteBoton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<Image>();
        spriteItem = spriteBoton.sprite != null ? Instantiate(spriteBoton.sprite) : null;
        seleccionar.Play();
        charlie.SetBool("Hover", true);

        switch (NombreItem)
        {
            case "boina":
                SetData("Boina de ilustradora",
                    "Una boina robada de una ilustradora que luchaba contra robots, es bastante cómoda e inspira creatividad.",
                    50, 1);
                break;

            case "granja":
                SetData("Sombrero de paja",
                    "Sombrero robado de la granjera Maggie, es bueno para protegerse del sol.",
                    25, 1);
                break;

            case "arroz":
                SetData("Sombrero de arroz",
                    "Un sombrero de arroz, solo eso. Se ve bien. Aunque el mío es mejor.",
                    50, 1);
                break;

            case "g_escurridizo":
                SetData("Gusano Escurridizo",
                    "Un escurridizo y picante gusano que aumenta la velocidad por 4 segundos.",
                    20, 3);
                break;

            case "g_musculoso":
                SetData("Gusano Musculoso",
                    "Un gigante y musculoso gusano que aumenta la fuerza por 4 segundos.",
                    20, 3);
                break;

            case "g_legendario":
                SetData("Gusano Legendario",
                    "Un reluciente y poderoso gusano con propiedades curativas y potenciadoras. Añade un corazón adicional en el HP y recupera toda la salud.",
                    100, 1);
                break;

            case "g_saludable":
                SetData("Gusano Saludable",
                    "Un rosado y delicioso gusano con propiedades curativas. Recupera +1 HP.",
                    15, 4);
                break;

            case "camionero":
                SetData("Gorra de camionero",
                    "Una gorra encontrada en la parada de camiones. Tiene manchas de aceite y huele a cigarrillos.",
                    20, 1);
                break;

            case "cofia":
                SetData("Cofia",
                    "Una cofia sucia y asquerosa encontrada en la basura de un matadero.",
                    10, 1);
                break;

            case "panoleta":
                SetData("Pañoleta",
                    "Una linda pañoleta con puntos, robada de la granjera Maggie.",
                    15, 1);
                break;

            case "halloween":
                SetData("Sombrero de bruja",
                    "Sombrero temático para Halloween.",
                    20, 1);
                break;

            case "navidad":
                SetData("Gorro de navidad",
                    "Gorro temático para Navidad.",
                    20, 1);
                break;

            case "e_oxidada":
                SetData("Espuelas oxidadas",
                    "Viejas espuelas encontradas en la basura. El riesgo de contraer tétanos para el enemigo es bajo, pero nunca nulo.",
                    15, 1);
                break;

            case "e_ornamental":
                SetData("Espuelas ornamentales",
                    "Elegantes espuelas doradas encontradas en una parada de camiones. Transmiten lujo y ciegan a sus enemigos con su brillo.",
                    30, 1);
                break;

            case "e_acero":
                SetData("Espuelas de acero inoxidable",
                    "Resistentes y filosas. Estas espuelas encontradas en un matadero pueden cortar hasta el metal.",
                    50, 1);
                break;

            case "e_cobre":
                SetData("Espuelas de cobre",
                    "Pulidas pero algo débiles. Son levemente mejores a las espuelas oxidadas, ya que podrás atacar más rápido.",
                    25, 1);
                break;

            case "lentes":
                SetData("Lentes de sol",
                    "Los lentes de una empresaria malvada. Son costosos, pero me los robé, así que son más baratos.",
                    40, 1);
                break;

            case "larva":
                SetData("Larva",
                    "Pequeña larva curativa, pero no tan buena en ello, cura +0.5 HP.",
                    5, 10);
                break;
        }
    }

    public void SetData(string nombre, string descripcion, int precio, int cant)
    {
        Nombre.text = nombre;
        Descripcion.text = descripcion;
        Precio.text = precio.ToString();
        valor = precio;
        cantidad = cant;
    }
    public void Pagar()
    {
        if (cantidad <= 0)
        {
            Agotado();
            Precio.text = "";
            return;
        }

        if (dinero < valor)
        {
            insuficiente.Play();
            Nombre.text = "Booo";
            Descripcion.text = "Ya no te queda maíz, eres pobre.";
            return;
        }

        dinero -= valor;
        cantidad--;

        DineroDisponible.text = dinero.ToString();
        comprado.Play();
        charlie.SetTrigger("Compra");
        charlie.SetBool("Hover", false);


        if (cantidad <= 0)
            Agotado();
    }

    private void Agotado()
    {
        spriteBoton.sprite = agotado;
        insuficiente.Play();
        spriteBoton.transform.GetComponent<Button>().interactable = false;
        Nombre.text = "¡Gracias!";
        Descripcion.text = "Ese item ya está agotado. ¡Elige otro!";
    }
    public void PoneLaMusica()
    {
        if(!music.isPlaying)
        {
            music.Play();
            ranaRadio.SetBool("Funcionando", true);
        }     

        else
        {
            music.Pause();
            ranaRadio.SetBool("Funcionando", false);
        }     
    }
    public void PausaLaMusica()
    {
        if(music.isPlaying)
        {
            music.Stop();
        }     
        music.time = 0f;
        ranaRadio.SetBool("Funcionando", false);        
    }

    public void UsarAhorros()
    {
        
        if (ahorro <= 0)
            return;

        
        ahorro--;

        
        dinero += ahorroDinero;

        AhorroDisponible.text = ahorro.ToString();
        DineroDisponible.text = dinero.ToString();

        if (ahorro <= 0)
        {
            UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject
                .GetComponent<Button>().interactable = false;
        }
    }
}
