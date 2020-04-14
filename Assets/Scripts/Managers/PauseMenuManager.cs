using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{

    public KeyCode pauseMenuKey;
    public GameObject pauseMenu;
    public bool paused;
    public PauseMenuManager s_Singleton;
    public GameObject torchLight;
    public bool torchReverse;

    private void Awake()
    {
        if (s_Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            s_Singleton = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
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
            paused = true;

            
            torchLight.SetActive(false);
        }

        else
        {
            Time.timeScale = 1;
            paused = false;

            torchLight.SetActive(true);
        }
    }

    //fonction continuer du pauseMenu
    public void Continuer()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        Time.timeScale = 1;
        paused = false;
    }

    //fonction option
    public void Option()
    {

    }

    //fonction du retour au menu principale
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(gameObject);
    }

    //fonction pour quitter le jeu
    public void Quit()
    {
        Application.Quit();
    }
}
