using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDraw : MonoBehaviour
{
    
    public KeyCode hideKey;
    public GameObject elementToHide;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(hideKey))
        {
            DrawUI();
        }
    }

    //fonction pour montrer les éléments d'UI
    public void DrawUI()
    {
        if(elementToHide == null)
        {
            elementToHide = GameObject.Find("UIManager");
        }
        else
        {
            elementToHide.SetActive(!elementToHide.activeSelf);
        }
    }

}
