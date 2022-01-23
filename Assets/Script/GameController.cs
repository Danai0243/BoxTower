using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController instance;
    public BoxSpawner boxSpawner;
    public Box currentBox;

    public Camerafollow Camerafollow;
    public static int score;

    public Text ScoreSendToUiRestart;
    public Text scoretxt;
    public int moveCount;

    public GameObject GameOver_1;
    public GameObject GameOver_2;

    public GameObject Ground;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    // Use this for initialization
    void Start()
    {

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseInput();
    }
    void GetMouseInput()
    {

        if (Input.GetMouseButtonDown(0))
        {
            currentBox.DropBox();
        }
    }

    public void SpawnNewBox()
    {

        Invoke("NextBox", 1f);
    }

    public void NextBox()
    {
        boxSpawner.SpawnBox();
    }
    public void addScore()
    {
        score++;
        scoretxt.text = "" + score;
        ScoreSendToUiRestart.text = score.ToString();
    }

    public void MoveCamera()
    {
        moveCount++;
        if (moveCount == 2)
        {
            GameOver_1.transform.position = new Vector3(-3, -4.61f, 0);
            GameOver_2.transform.position = new Vector3(3, -4.61f, 0);
            moveCount = 0;
            Camerafollow.targetPos.y += 2f;
        }
    }
}
