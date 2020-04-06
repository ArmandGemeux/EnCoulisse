using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour
{

    public GameObject lightObject;
    public GameObject torchLight;
    public Vector2 distance;
    public float ecart;

    // Start is called before the first frame update
    void Start()
    {
        torchLight = GameObject.FindGameObjectWithTag("TorchLight");
    }

    // Update is called once per frame
    void Update()
    {
        distance = lightObject.transform.position - torchLight.transform.position;
        ecart = Mathf.Abs(distance.x + distance.y);
        //lightObject.GetComponent<Light>().range = 0.1f + (ecart / 2);
        //lightObject.GetComponent<Light>().range = 0.7f + (ecart / 20);
        lightObject.GetComponent<Light>().range = 0.7f + (2 / (ecart + 0.5f));
        if(lightObject.GetComponent<Light>().range >= 2)
        {
            lightObject.GetComponent<Light>().range = 2;
        }
    }
}
