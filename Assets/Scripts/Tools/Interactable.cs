using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



//script obsolète
public class Interactable : MonoBehaviour
{
    public bool interaction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TorchLight"))
        {
            if (Input.GetMouseButton(0))
            {
                interaction = true;
            }
            
        }
    }

    
}
