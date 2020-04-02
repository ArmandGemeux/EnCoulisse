using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{

    public KeyCode pauseMenuKey;
    public GameObject pauseMenu;

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

    }

    //fonction d'activation/désactivation du pause menu
    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        if(pauseMenu.activeSelf == true)
        {
            Time.timeScale = 0;
        }

        if (pauseMenu.activeSelf == false)
        {
            Time.timeScale = 1;
        }
    }

    //fonction continuer du pauseMenu
    public void Continuer()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }

    //fonction option
    public void Option()
    {

    }

    //fonction du retour au menu principale
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //fonction pour quitter le jeu
    public void Quit()
    {
        Application.Quit();
    }

}
