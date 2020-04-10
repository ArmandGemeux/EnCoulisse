using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{

    public List<GameObject> scaryPictures;
    public int pictureNumber;
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
        distance = this.transform.position - torchLight.transform.position;
        ecart = Mathf.Abs(distance.x + distance.y);
        if(ecart < 0.1f)
        {
            Instantiate(scaryPictures[pictureNumber]);
            Fungus.Flowchart.BroadcastFungusMessage("SCARY");
            Destroy(this.gameObject);
        }
    }
}
