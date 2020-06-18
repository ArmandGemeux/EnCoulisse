using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClicToContinue : MonoBehaviour
{
    public Vector3 mousePosition;
    public TextMeshProUGUI text;
    public Color textColor;
    public float timer;
    public Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        textColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        text.color = textColor;

        timer += Time.deltaTime;
        if(timer >= 0.1f)
        {
            lastPosition = mousePosition;
            timer = 0;
        }
        

        if (lastPosition == mousePosition)
        {
            textColor.a -= 0.01f;
        }
        else
        {
            textColor.a = 1;
        }
    }
}
