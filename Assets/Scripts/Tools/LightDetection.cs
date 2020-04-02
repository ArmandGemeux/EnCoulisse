using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDetection : MonoBehaviour
{

    //le signal lumineux emis pour l'interaction
    public GameObject lightSignal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }


    //lors du rapprochement, la lumière s'active
    private void OnTriggerEnter(Collider other)
    {
        lightSignal.SetActive(true);
    }

    //lors de l'éloignement, la lumière se désactive
    private void OnTriggerExit(Collider other)
    {
        lightSignal.SetActive(false);
    }
}
