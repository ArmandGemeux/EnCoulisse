using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogButtonManager : MonoBehaviour
{

    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("PauseMenuManager"))
        {
            pauseMenu = GameObject.FindGameObjectWithTag("PauseMenuManager");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.timeScale);
    }

    public void TogglePause()
    {
        if(pauseMenu != null)
        {
            pauseMenu.GetComponent<PauseMenuManager>().TogglePauseMenu();
        }
    }

    public void ToggleSpeed()
    {
        Debug.Log("clic");
        
        if(Time.timeScale != 2)
        {
            Time.timeScale = 2;
        }
        else
        {
            Time.timeScale = 1;
        }

    }

    public void Skip()
    {
        Fungus.Flowchart.BroadcastFungusMessage("Skip");
    }

    public void ToggleHistory()
    {

    }

}
