﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{

    public KeyCode pauseMenuKey;
    public GameObject pauseMenu;
    public GameObject torchLight;
    public bool paused;
    public bool reversed;
    public GameObject pressP;
    public GameObject pP;
    public bool canPressP;
    public bool spawnP;
    public float timerP;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //si je joueur appuis le bouton pause, alors toggle oui/non le pauseMenu
        if (Input.GetKeyDown(pauseMenuKey))
        {
            
            TogglePauseMenu();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            canPressP = true;
            spawnP = true;
        }

        if (canPressP)
        {
            if (spawnP)
            {
                pP = Instantiate(pressP);
                spawnP = false;
            }
            timerP += Time.deltaTime;
            if(timerP >= 3)
            {
                Destroy(pP);
                timerP = 0;
                canPressP = false;
            }
        }
        
    }

    //fonction d'activation/désactivation du pause menu
    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        
        if(pauseMenu.activeSelf == true)
        {
            if(torchLight.activeSelf == true)
            {
                reversed = true;
                torchLight.SetActive(false);
            }
            Time.timeScale = 0;
            paused = true;
            Fungus.Flowchart.BroadcastFungusMessage("setPause");
        }

        

        else
        {
            if(reversed == true)
            {
                torchLight.SetActive(true);
                reversed = false;
            }
            Time.timeScale = 1;
            paused = false;
            Fungus.Flowchart.BroadcastFungusMessage("setUnpause");
        }
    }

    //fonction continuer du pauseMenu
    public void Continuer()
    {
        TogglePauseMenu();
    }

    //fonction option
    public void Option()
    {

    }

    //fonction du retour au menu principale
    public void ReturnMainMenu()
    {
        Time.timeScale = 1;
        paused = false;
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

    //fonction pour quitter le jeu
    public void Quit()
    {
        Application.Quit();
    }
    

}
