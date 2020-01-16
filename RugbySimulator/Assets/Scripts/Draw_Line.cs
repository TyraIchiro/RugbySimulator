using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw_Line : MonoBehaviour
{
    bool isalive = false;
    GameObject field;

    // Start is called before the first frame update
    void Start()
    {
        field = GameObject.Find("AllGround");
        //field.GetComponent<ManipulationHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Draw_Stop()
    {
        if (isalive)
        {
            isalive = false;
        }
        else
        {
            isalive = true;
        }
    }
}
