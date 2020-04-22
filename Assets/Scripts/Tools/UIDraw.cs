using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIDraw : MonoBehaviour
{

    public GameObject backGround;
    public KeyCode hideKey;
    private static UIDraw s_Singleton;
    public GameObject screen;
    public bool uI;


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
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(hideKey))
        {
            DrawUI();
        }
        if (uI)
        {
            var mousePos = Input.mousePosition;
            mousePos.x -= Screen.width / 2;
            mousePos.y -= Screen.height / 2;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    //fonction pour montrer les éléments d'UI
    public void DrawUI()
    {
        
        int sceneIndex;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(sceneIndex != 0)
        {
            if(GameObject.FindGameObjectWithTag("Background") != null)
            {
                backGround = GameObject.FindGameObjectWithTag("Background");
                screen.SetActive(!screen.activeSelf);
                screen.GetComponent<Image>().sprite = backGround.GetComponent<SpriteRenderer>().sprite;
                if (screen.activeSelf == true)
                {
                    uI = true;
                }
                else
                {
                    uI = false;
                }
            }
        }
    }
    private void OnDisable()
    {
        if(uI == true)
        {
            DrawUI();
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
