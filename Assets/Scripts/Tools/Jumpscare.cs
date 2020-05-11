﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    
    public int pictureNumber;
    public GameObject torchLight;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        torchLight = GameObject.FindGameObjectWithTag("TorchLight");
    }

    // Update is called once per frame
    void Update()
    {
        distance =  Vector2.Distance(torchLight.transform.position, gameObject.transform.position);
        if (distance < 0.6f)
        {
            Fungus.Flowchart.BroadcastFungusMessage("SCARY");
            Destroy(this.gameObject);
        }
    }
}
