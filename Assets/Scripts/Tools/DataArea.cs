using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataArea : MonoBehaviour
{
    public GameObject data;
    public GameObject torchLight;
    public float distance;

    public TextMeshProUGUI nameSection;

    public string nameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("TorchLight"))
        {
            torchLight = GameObject.FindGameObjectWithTag("TorchLight");
            distance = Vector2.Distance(torchLight.transform.position, gameObject.transform.position);
            if (distance < 1f)
            {
                data.SetActive(true);
            }
            else
            {
                data.SetActive(false);
            }
        }
    }
}
