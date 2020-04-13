﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class RoomManager : MonoBehaviour
{

    /*public string avant;
    public string arriere;
    public string gauche;
    public string droite;
    

    public KeyCode up;
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
        //si le joueur appuis sur la flèche du haut, il se déplacera sur la salle avant.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Fungus.Flowchart.BroadcastFungusMessage("Go up");
        }

        //si le joueur appuis sur la flèche du bas, il se déplacera sur la salle arrière.
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Fungus.Flowchart.BroadcastFungusMessage("Go down");
        }

        //si le joueur appuis sur la flèche de gauche, il se déplacera sur la salle à gauche
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Fungus.Flowchart.BroadcastFungusMessage("Go left");
        }

        //si le joueur appuis sur la flèche de droite, il se déplacera sur la salle à droite.
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Fungus.Flowchart.BroadcastFungusMessage("Go right");
        }
    }
    
}
