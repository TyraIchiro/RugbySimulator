﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetEnemyMember : MonoBehaviour
{
    public GameObject[] Enemy = new GameObject[15];
    public GameObject Menber = null;

    // Start is called before the first frame update
    void Start()
    {
        Enemy[0] = GameObject.Find("Enemy_01");
        Enemy[1] = GameObject.Find("Enemy_02");
        Enemy[2] = GameObject.Find("Enemy_03");
        Enemy[3] = GameObject.Find("Enemy_04");
        Enemy[4] = GameObject.Find("Enemy_05");
        Enemy[5] = GameObject.Find("Enemy_06");
        Enemy[6] = GameObject.Find("Enemy_07");
        Enemy[7] = GameObject.Find("Enemy_08");
        Enemy[8] = GameObject.Find("Enemy_09");
        Enemy[9] = GameObject.Find("Enemy_10");
        Enemy[10] = GameObject.Find("Enemy_11");
        Enemy[11] = GameObject.Find("Enemy_12");
        Enemy[12] = GameObject.Find("Enemy_13");
        Enemy[13] = GameObject.Find("Enemy_14");
        Enemy[14] = GameObject.Find("Enemy_15");

        int i = 0;
        while (i < 15)
        {
            Enemy[i].SetActive(false);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int E = 0;
    public void OnClickTapEvent()
    {
        Text Menber_text = Menber.GetComponent<Text>();
        if (E > 14)
        {
            Debug.Log("Full Enemy");
            Menber_text.text = "Full Enemy";
        }
        else
        {
            // Enemy[j].SetActive(true);
            E++;
            Menber_text.text = "Enemy:" + E;
            Debug.Log("Enemy:" + E);
        }
    }
}
