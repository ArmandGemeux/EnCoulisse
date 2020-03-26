using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public bool canInteract;
    public bool goTimer;
    public float timer;
    public GameObject fadeOut;
    public GameObject light;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canInteract)
        {
            Interaction();
        }
        if (goTimer)
        {
            timer += 1 * Time.deltaTime;
            if(timer >= 1.5f)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    public void Interaction()
    {
        goTimer = true;
        fadeOut.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TorchLight"))
        {
            if (Input.GetMouseButton(0))
            {
                canInteract = true;
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        light.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        light.SetActive(false);
    }
}
