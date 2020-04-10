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
        GameObject[] writing;
        writing = GameObject.FindGameObjectsWithTag("Dialogue");

        int i;
        for(i = 0; i< writing.Length; i++)
        {
            if (GetComponent<Fungus.Writer>().writingSpeed != 120)
            {
                GetComponent<Fungus.Writer>().writingSpeed = 120;

                //Time.timeScale = 2;
            }
            else
            {
                GetComponent<Fungus.Writer>().writingSpeed = 60;
            }
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
