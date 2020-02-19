using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class Field_Alive : MonoBehaviour
{
    public GameObject field;
    ManipulationHandler f_hnd;
    bool isalive = false;

    // Start is called before the first frame update
    void Start()
    {
        f_hnd = field.GetComponent<ManipulationHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move_Stop()
    {
        if (isalive)
        {
            f_hnd.enabled = true;
            isalive = false;
        }
        else
        {
            f_hnd.enabled = false;
            isalive = true;
        }
    }
}
