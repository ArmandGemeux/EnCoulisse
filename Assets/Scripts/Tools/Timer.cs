﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float timerInitial;
    public float timer;
    public bool goTimer;
    public TextMeshProUGUI timerText;
    public GameObject image;

    // Start is called before the first frame update
    void Start()
    {
        timer = 1;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (goTimer)
        {
            timer -= 1 * Time.deltaTime;
            image.SetActive(true);
            timerText.gameObject.SetActive(true);
            timerText.text = "" + (int)timer;
            if(timer <= 0)
            {
                Fungus.Flowchart.BroadcastFungusMessage("TimeOut");
                timer = 1;
                goTimer = false;
            }
        }
    }

    public void setTimer(float setTimer)
    {
        timer = setTimer;
        
    }

    public void GoTimer()
    {
        goTimer = true;
    }

}
