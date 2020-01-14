using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class Field_Alive : MonoBehaviour
{
    GameObject field;
    ManipulationHandler f_hnd;
    bool isalive;

    // Start is called before the first frame update
    void Start()
    {
        field = GameObject.Find("AllGround");
        f_hnd = field.GetComponent<ManipulationHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move_Stop()
    {
        if (f_hnd.enabled == true)
        {
            f_hnd.enabled = false;
        }
        else
        {
            f_hnd.enabled = true;
        }
    }
}
