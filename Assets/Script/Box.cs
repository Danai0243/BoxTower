using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Box : MonoBehaviour
{
    float MinX = -2.32f;
    float MaxX = 2.32f;
    Rigidbody2D rb;
    bool CanMove = false;
    float MoveSpeed = 2f;

    bool ignoreCollision;
    bool ignoreTrigger;

    bool isGameOver;

    bool isGround;

    bool isBox;

    int checkBox;

    public static bool OnOff = false;

    public static GameObject BtnEndGame;


    void OnCollisionEnter2D(Collision2D other)
    {

        if (ignoreCollision) return;
        if (other.gameObject.tag == "Ground")
        {
            ignoreTrigger = true;
            isGround = true;
            Invoke("OnGround", 1f);
            checkBox++;
            if (checkBox > 1)
            {
                OnOff = true;
                Time.timeScale = 0;

            }
            Debug.Log("Box");
            Debug.Log(checkBox);


        }
        if (other.gameObject.tag == "Box")
        {
            isBox = true;
            ignoreTrigger = true;
            GameController.instance.addScore();
            GameController.instance.MoveCamera();
            Invoke("OnGround", 1f);
        }




    }

    public void OnGround()
    {
        if (isGameOver) return;
        ignoreCollision = true;
        GameController.instance.SpawnNewBox();

    }
    public void DropBox()
    {
        CanMove = false;
        rb.gravityScale = Random.Range(2, 4);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if (GameController.score >= 3)
        // {
        //     if (ignoreTrigger) return;
        // }
        // 
        if (other.gameObject.tag == "GameOver")
        {
            CancelInvoke("OnGround");
            isGameOver = true;
            ignoreTrigger = true;
            OnOff = true;
            Time.timeScale = 0;
            // Invoke("RestartGame", 1f);

        }

    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;


        // BtnEndGame.SetActive(false);
        // BtnEndGame.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {

        CanMove = true;
        if (Random.Range(0, 2) > 0)
        {
            MoveSpeed *= -1f;
        }
        GameController.instance.currentBox = this;
        OnOff = false;
    }

    void MoveBox()
    {
        if (CanMove == true)
        {
            Vector3 temp = transform.position;
            temp.x += MoveSpeed * Time.deltaTime;
            if (temp.x > MaxX)
            {
                MoveSpeed *= -1f;
            }
            else if (temp.x < MinX)
            {
                MoveSpeed *= -1f;
            }
            transform.position = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveBox();
        // Debug.Log(GameController.score);


    }
}
