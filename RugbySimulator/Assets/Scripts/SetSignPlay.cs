using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSignPlay : MonoBehaviour
{
    string[] SignPlay = new string[6];
    public GameObject Sign = null;

    // Start is called before the first frame update
    void Start()
    {
        SignPlay[0] = "Cross";
        SignPlay[1] = "Short";
        SignPlay[2] = "Tobashi";
        SignPlay[3] = "Loop";
        SignPlay[4] = "KaraCross";
        SignPlay[5] = "DoubleCross";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int S = 0;
    public void OnClickTapEvent()
    {
        Text Sign_text = Sign.GetComponent<Text>();
        Sign_text.text = SignPlay[S];
        Debug.Log(SignPlay[S]);
        if (S == 5)
        {
            S = 0;
        } 
        else
        {
            S++;
        }
    }
}
