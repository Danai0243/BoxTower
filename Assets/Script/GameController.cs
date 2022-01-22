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
    public Text scoretxt;
    public int moveCount;
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
        Debug.Log("ทดสอบ");
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
    }

    public void MoveCamera()
    {
        moveCount++;
        if (moveCount == 3)
        {
            moveCount = 0;
            Camerafollow.targetPos.y += 2f;
        }
    }
}
