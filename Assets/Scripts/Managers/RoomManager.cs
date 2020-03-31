using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class RoomManager : MonoBehaviour
{

    public string avant;
    public string arriere;
    public string gauche;
    public string droite;

    /*public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;*/



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(avant != null)
            {
                SceneManager.LoadScene(avant);
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (arriere != null)
            {
                SceneManager.LoadScene(arriere);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (gauche != null)
            {
                SceneManager.LoadScene(gauche);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (droite != null)
            {
                SceneManager.LoadScene(droite);
            }
        }
    }
    
}
