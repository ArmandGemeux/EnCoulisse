using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEvents : MonoBehaviour
{

    public float timer;
    public bool canTimer;

    // Start is called before the first frame update
    void Start()
    {
        canTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canTimer)
        {
            timer += Time.deltaTime;
        }
        if(timer >= 20)
        {
            canTimer = false;
            Fungus.Flowchart.BroadcastFungusMessage("RandomEvent");
            timer = 0;
        }
        else
        {
            canTimer = true;
        }
    }
}
