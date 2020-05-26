using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogButtonManager : MonoBehaviour
{

    public GameObject pauseMenu;
    public KeyCode history;
    public GameObject saveMenu;
    public GameObject buttonColor;


    // Start is called before the first frame update
    void Start()
    {
        saveMenu = GameObject.Find("SaveMenu");

        if (GameObject.FindGameObjectWithTag("PauseMenuManager"))
        {
            pauseMenu = GameObject.FindGameObjectWithTag("PauseMenuManager");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(history))
        {
            saveMenu.GetComponent<Fungus.SaveMenu>().ToggleSaveMenu();
            saveMenu.GetComponent<Fungus.NarrativeLogMenu>().ToggleNarrativeLogView();
        }
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
        if (GetComponent<Fungus.Writer>().writingSpeed != 180)
        {
            buttonColor.GetComponent<Image>().color = Color.grey;
            GetComponent<Fungus.Writer>().writingSpeed = 180;

            //Time.timeScale = 2;
        }
        else
        {
            buttonColor.GetComponent<Image>().color = Color.white;
            GetComponent<Fungus.Writer>().writingSpeed = 60;
        }

        

    }

    public void Skip()
    {
        Fungus.Flowchart.BroadcastFungusMessage("Skip");
    }

    private void OnEnable()
    {
        if(saveMenu != null)
        {
            saveMenu.SetActive(true);
        }
    }

    private void OnDisable()
    {
        if (saveMenu != null)
        {
            saveMenu.SetActive(false);
        }
    }

}
