using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollowMouse : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Confined;
        //torchLight.transform.position = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z -1)));
        newPos.z = transform.position.z;

        transform.position = newPos;

        //transform.position = new Vector3(Input.mousePosition.x - Camera.main.transform.position.x, Input.mousePosition.y - Camera.main.transform.position.y, -1);
    }

    private void OnDisable()
    {
        Cursor.visible = true;
    }

    private void OnEnable()
    {
        Cursor.visible = false;
    }
}
