using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class Field_Alive : MonoBehaviour
{
    public GameObject field;
    ManipulationHandler f_hnd;
    bool isalive_f = false;
    bool isalive_b = true;
    public Camera bird;
    public float baseWidth = 1.0f;
    public float baseHeight = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        f_hnd = field.GetComponent<ManipulationHandler>();
        bird.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move_Stop()
    {
        if (isalive_f)
        {
            f_hnd.enabled = true;
            isalive_f = false;
        }
        else
        {
            f_hnd.enabled = false;
            isalive_f = true;
        }
    }

    public void Bird()
    {
        if (isalive_b)
        {
            bird.enabled = true;
            isalive_b = false;
        }
        else
        {
            bird.enabled = false;
            isalive_b = true;
        }
    }
}
