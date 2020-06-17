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
        JumpScare();

        if (gameObject.CompareTag("Temporaire"))
        {
            Destroy(gameObject, 5f);
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

    public void JumpScare()
    {
        if (gameObject.CompareTag("Jumpscare"))
        {
            Destroy(gameObject, 0.1f);
        }
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
        if (gameObject.CompareTag("Temporaire"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("RestoreScene");
            Destroy(gameObject);
        }
        else
        {
            Fungus.Flowchart.BroadcastFungusMessage("OutPicture");
            Destroy(gameObject);
        }
    }

    public void SendMessOne()
    {
        Fungus.Flowchart.BroadcastFungusMessage("RestoreScene");
        Destroy(gameObject);
    }

    public void SendMes2()
    {
        Fungus.Flowchart.BroadcastFungusMessage("OutPicture2");
        Destroy(gameObject);
    }

    public void OutData()
    {
        Fungus.Flowchart.BroadcastFungusMessage("OutData");
        Destroy(gameObject);
    }

    public void SendPhoto()
    {
        Fungus.Flowchart.BroadcastFungusMessage("OutPhoto");
        Destroy(gameObject);
    }

    public void SendShake()
    {
        Fungus.Flowchart.BroadcastFungusMessage("Shake");
        Destroy(gameObject);
    }


    private void OnDestroy()
    {
        if (gameObject.CompareTag("Temporaire"))
        {
            Fungus.Flowchart.BroadcastFungusMessage("OutPicture");
        }
    }
}
