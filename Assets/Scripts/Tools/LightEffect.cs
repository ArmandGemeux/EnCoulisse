using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEffect : MonoBehaviour
{

    public GameObject lightZone;
    public float timer;
    public bool goEffect;
    public bool lighting;
    public int clic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpamLight();
        }

        if (goEffect)
        {
            timer += 1 * Time.deltaTime;

            if (timer >= 0.1f && lighting == true)
            {
                lighting = false;
                timer = 0;
                clic += 1;
            }

            if (timer >= 0.1f && lighting == false)
            {
                lighting = true;
                timer = 0;
                clic += 1;
            }

            if (lighting)
            {
                lightZone.SetActive(true);
                GetComponent<Light>().enabled = true;
            }
            if(lighting == false)
            {
                lightZone.SetActive(false);
                GetComponent<Light>().enabled = false;
            }

            if(clic >= 4)
            {
                lightZone.SetActive(true);
                GetComponent<Light>().enabled = true;
                clic = 0;
                goEffect = false;
            }

        }
    }

    public void SpamLight()
    {
        goEffect = true;
    }

}
