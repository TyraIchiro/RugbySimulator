using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetSituation : MonoBehaviour
{
    public GameObject A_box;
    public GameObject E_box;
    public GameObject S_box;
    SetAllyMember Ally;
    SetEnemyMember Enemy;
    SetSignPlay Sign;
    public int A;
    public int E;
    public int S;

    // Start is called before the first frame update
    void Start()
    {
        Ally = A_box.GetComponent<SetAllyMember>();
        Enemy = E_box.GetComponent<SetEnemyMember>();
        Sign = S_box.GetComponent<SetSignPlay>();
    }

    // Update is called once per frame
    void Update()
    {
        A = Ally.A;
        E = Enemy.E;
        S = Sign.S;
    }

    public void OnClickTapEvent()
    {
        if (A == 0 && E == 0)
        {
            Debug.Log("Please set member");
        }
        else
        {
            SceneManager.LoadScene("Memory");
        }
    }
}
