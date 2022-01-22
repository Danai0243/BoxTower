using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pop1 : MonoBehaviour
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
        Time.timeScale = 0;
        PopupBtn.SetActive(true);
        animator.SetBool("visible", true);
    }
    public void Hide(Animator animator)
    {
        Time.timeScale = 1;
        animator.SetBool("visible", false);
        PopupBtn.SetActive(false);

    }
}
