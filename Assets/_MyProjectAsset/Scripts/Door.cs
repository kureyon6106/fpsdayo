using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private Animator animator;
    private bool isOpen;

    void Start()
    {
        animator = GetComponent<Animator>();
        isOpen = animator.GetBool("isOpen");
    }

    void OnTriggerStay (Collider other)
    {
        if (other.tag != "Player") return;
        if (Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
            animator.SetBool("isOpen", isOpen);
        }
    }
}
