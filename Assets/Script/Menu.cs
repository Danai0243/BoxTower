using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Application.LoadLevel("PlayScene");
    }
    public void QuiteGame()
    {
        Application.Quit();
    }
}
