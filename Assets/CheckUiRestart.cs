using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUiRestart : MonoBehaviour
{

    // Use this for initialization

    GameObject BtnEndGame;

    void Start()
    {
        BtnEndGame = GameObject.FindGameObjectWithTag("RestartUi");

    }

    // Update is called once per frame
    void Update()
    {
        BtnEndGame.SetActive(Box.OnOff);

    }
}
