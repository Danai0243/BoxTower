using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Endgame : MonoBehaviour
{
    public Text score;
    GameObject BtnEndGame;

    // Use this for initialization
    void Start()
    {
        // score.text = GameController.score.ToString();
        // GameController.score;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void RestartGame()
    {

        Box.BtnEndGame.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
