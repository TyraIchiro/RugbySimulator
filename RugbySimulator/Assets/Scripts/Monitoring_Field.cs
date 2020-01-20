using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitoring_Field : MonoBehaviour
{
    public static GameObject isTappingPlayer;
    public static bool moni_mode;

    // Start is called before the first frame update
    void Start()
    {
        moni_mode = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Moni_Field()
    {
        if (Draw_Mode.isalive)
        {
            moni_mode = false;
        }
        else
        {
            moni_mode = true;
        }
    }
}
