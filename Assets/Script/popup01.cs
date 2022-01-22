using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class popup01 : MonoBehaviour
{
    public GameObject PopupBtn;

    private void Start()
    {
        PopupBtn.SetActive(false);
    }

    public void Start(Animator animator)
    {
        animator.SetBool("visible", false);
    }
    public void Show(Animator animator)
    {
        PopupBtn.SetActive(true);
        animator.SetBool("visible", true);
    }
    public void Hide(Animator animator)
    {
        animator.SetBool("visible", false);
    }
}
