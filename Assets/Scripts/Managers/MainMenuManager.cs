using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    public GameObject mainImage;
    public GameObject imageShowed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void Jouer()
    {
        SceneManager.LoadScene("Hall");
    }

    public void options()
    {

    }

    public void Galerie()
    {

    }*/

    public void Quit()
    {
        Application.Quit();
    }

    public void SetMainImage(Button buttonImageToShow)
    {
        mainImage.SetActive(true);
        imageShowed.GetComponent<Image>().sprite = buttonImageToShow.gameObject.GetComponent<Image>().sprite;
        
    }

}
