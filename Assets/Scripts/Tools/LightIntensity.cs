﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour
{

    public GameObject lightObject;
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
        if(lightObject != null)
        {
            distance = Vector2.Distance(torchLight.transform.position, gameObject.transform.position);
        }


        //rétrécir
        //lightObject.GetComponent<Light>().range = 0.1f + (ecart / 2);
        //lightObject.GetComponent<Light>().range = 0.7f + (ecart / 20);
        //lightObject.GetComponent<Light>().range = 0.7f + (ecart);


        //agrandir
        //lightObject.GetComponent<Light>().range = 0.1f + (10 / (ecart + 0.5f));
        lightObject.GetComponent<Light>().range = 0.001f + (1 / (distance + 0.5f));


        if (lightObject.GetComponent<Light>().range >= 10)
        {
            lightObject.GetComponent<Light>().range = 10;
        }
    }
}
