using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timerr : MonoBehaviour
{
    public Text timerText;
    private float startTime = 60f;
    public Text GameOver;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        timerText.text = " " + startTime ;
        if (startTime <= 0.0f)
        {
            GameOver.text = "Game Over!";
            Application.Quit();
        }

    }
}
