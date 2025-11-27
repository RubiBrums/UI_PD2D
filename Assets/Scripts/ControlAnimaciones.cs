using Unity.VisualScripting;
using UnityEngine;

public class ControlAnimaciones : MonoBehaviour
{
     Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        Animaciones();
    }

    void Animaciones()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetTrigger("idle");
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetTrigger("walk");
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetTrigger("jump");
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            animator.SetTrigger("attack");
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            animator.SetTrigger("libre");
        }
    }
}
