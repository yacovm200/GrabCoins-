using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    public int score = 0;
    
    public Text Points;
    public Text GameOver;
    public Text PlayerWon;
    public float targetTime = 60f;

    // Update is called once per frame

    void Update()
    {
        MovementOfPlayer();
        CheckIfPlayerWonOrGameOver(); 
        Points.text = "Points: " + score;
        targetTime -= Time.deltaTime;

       

    }

    private void CheckIfPlayerWonOrGameOver()
    {
        if (targetTime <= 0.0f)
        {
            GameOver.text = "Game Over!";
            Application.Quit();
        }

        if (score == 5)
        {
            PlayerWon.text = "     you won!";
            Application.Quit();
        }
    }

    private void MovementOfPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);


        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.2f);
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + "has colleted with " + collision.gameObject.name);

        if (collision.gameObject.name == "coin1" ||
            collision.gameObject.name == "coin2" ||
            collision.gameObject.name == "coin3" ||
            collision.gameObject.name == "coin4" ||
            collision.gameObject.name == "coin5")
        {
            score++;
            print("score now is: " + score); ;
        }
    }

}



