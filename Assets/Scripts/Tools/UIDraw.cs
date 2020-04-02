using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDraw : MonoBehaviour
{

    public List<GameObject> elementsToHide;
    public bool hidden;
    public KeyCode hideKey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(hideKey) && hidden == false)
        {
            DrawUI();
            hidden = true;
        }
        else
        {
            if (Input.GetKeyDown(hideKey) && hidden == true)
            {
                HideUI();
                hidden = false;
            }
        }
    }

    //fonction pour montrer les éléments d'UI
    public void DrawUI()
    {
        int i;
        for (i = 0; i < elementsToHide.Count; i++)
        {
            elementsToHide[i].SetActive(false);
        }
    }

    //fonction pour cacher les éléments d'UI
    public void HideUI()
    {
        int a;
        for (a = 0; a < elementsToHide.Count; a++)
        {
            elementsToHide[a].SetActive(true);
        }
    }

}
