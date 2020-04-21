using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureManager : MonoBehaviour
{
    public List<GameObject> documentContents;
    public int actualContent;

    // Start is called before the first frame update
    void Start()
    {
        actualContent = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Jumpscare"))
        {
            Destroy(gameObject, 0.1f);
        }
    }
    public void Previous()
    {
        int i;
        for(i = 0; i < documentContents.Count; i++)
        {
            documentContents[i].SetActive(false);
        }

        if(actualContent > 0)
        {
            actualContent -= 1;
        }

        documentContents[actualContent].SetActive(true);

    }

    public void next()
    {
        int i;
        for (i = 0; i < documentContents.Count; i++)
        {
            documentContents[i].SetActive(false);
        }
        if (actualContent < documentContents.Count-1)
        {
            actualContent += 1;
        }

        documentContents[actualContent].SetActive(true);
    }
    public void SendMes()
    {
        Fungus.Flowchart.BroadcastFungusMessage("OutPicture");
        Destroy(gameObject, 2f);
    }

    public void OutData()
    {
        Fungus.Flowchart.BroadcastFungusMessage("OutData");
        Destroy(gameObject);
    }

}
