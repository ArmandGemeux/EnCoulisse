using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using TMPro;

public class LightIntensity : MonoBehaviour
{

    public GameObject lightObject;
    public GameObject torchLight;
    public float distance;
    public bool detected;
    public float alphaText;
    public TextMeshProUGUI alphaColor;

    // Start is called before the first frame update
    void Start()
    {
        torchLight = GameObject.FindGameObjectWithTag("TorchLight");
    }

    // Update is called once per frame
    void Update()
    {
        if (detected && gameObject.CompareTag("Room"))
        {
            distance = Vector2.Distance(torchLight.transform.position, gameObject.transform.position);

            alphaText = 0.3f / distance;
            
            alphaColor.alpha = alphaText;

            if (lightObject.activeSelf == true)
            {
                lightObject.GetComponent<Light>().range = 0.001f + (1 / (distance + 0.5f));
            }

            if (distance >= 5)
            {
                lightObject.SetActive(false);
            }
            else
            {
                lightObject.SetActive(true);
            }
            if (lightObject.GetComponent<Light>().range >= 10)
            {
                lightObject.GetComponent<Light>().range = 10;
            }

        }
        
    }
}
