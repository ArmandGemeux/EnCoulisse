using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Jumpscare"))
        {
            Destroy(gameObject, 0.1f);
        }
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
