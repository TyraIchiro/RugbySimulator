using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_ID : MonoBehaviour
{
    public InputField IDField, PassField;
    public Text ID, Pass;

    // Start is called before the first frame update
    void Start()
    {
        IDField = IDField.GetComponent<InputField>();
        PassField = PassField.GetComponent<InputField>();
        ID = ID.GetComponent<Text>();
        Pass = Pass.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SignUp()
    {
        if (!File.Exists(ID + ".txt"))
        {
            string path = Application.dataPath + "/" + ID + ".txt";
            StreamWriter sw = File.CreateText(path);
            sw.Write(Pass);
            sw.Close();
            SceneManager.LoadScene("Create");
        }
        else
        {
            Debug.Log("このIDは登録済みです");
        }
    }

    public void LogIn()
    {
        if (File.Exists(ID + ".txt"))
        {
            string path = Application.dataPath + "/" + ID + ".txt";
            StreamWriter sw = File.CreateText(path);
            sw.Write(Pass);
            sw.Close();
        }
        else
        {
            Debug.Log("このIDは登録済みです");
        }
    }
}
