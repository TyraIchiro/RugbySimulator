﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAlly : MonoBehaviour
{
    public GameObject[] Ally = new GameObject[15];

    // Start is called before the first frame update
    void Start()
    {
        Ally[0] = GameObject.Find("Ally_01");
        Ally[1] = GameObject.Find("Ally_02");
        Ally[2] = GameObject.Find("Ally_03");
        Ally[3] = GameObject.Find("Ally_04");
        Ally[4] = GameObject.Find("Ally_05");
        Ally[5] = GameObject.Find("Ally_06");
        Ally[6] = GameObject.Find("Ally_07");
        Ally[7] = GameObject.Find("Ally_08");
        Ally[8] = GameObject.Find("Ally_09");
        Ally[9] = GameObject.Find("Ally_10");
        Ally[10] = GameObject.Find("Ally_11");
        Ally[11] = GameObject.Find("Ally_12");
        Ally[12] = GameObject.Find("Ally_13");
        Ally[13] = GameObject.Find("Ally_14");
        Ally[14] = GameObject.Find("Ally_15");

        int i = 0;
        while(i < 15)
        {
            Ally[i].SetActive(false);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int j = 0;
    public void OnClickTapEvent()
    {
        if ( j > 14 )
        {
            Debug.Log("Full Ally");
        }
        Ally[j].SetActive(true);
        j++;
    }
}
