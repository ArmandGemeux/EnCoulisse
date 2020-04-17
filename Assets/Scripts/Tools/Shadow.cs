using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{

    public float distance;
    public GameObject torchLight;
    public AudioSource audioSource;
    public AudioClip triggerSound;
    public float timer;
    public bool goTimer;

    // Start is called before the first frame update
    void Start()
    {
        torchLight = GameObject.FindGameObjectWithTag("TorchLight");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(torchLight != null)
        {
            distance = Vector2.Distance(torchLight.transform.position, gameObject.transform.position);
        }

        if (goTimer)
        {
            timer += 1 * Time.deltaTime;
            if(timer >= 3)
            {
                Destroy(gameObject);
            }
        }
        
        if (distance < 0.2f && goTimer != true)
        {
            audioSource.PlayOneShot(triggerSound);
            Destroy(GetComponent<SpriteRenderer>());
            goTimer = true;
        }

    }
}
