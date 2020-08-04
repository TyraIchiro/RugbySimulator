using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectAnimation : MonoBehaviour
{
    public int[] tmp = new int[3];
    public void sel_ani(int[] tmp)
    {
        int n = 0;

        if (tmp[0] == 3 && tmp[1] == 2 && tmp[2] == 0)
        {
            n = 1;
        }
        switch(n)
        {
            case 0:
                break;
            case 1:
                SceneManager.LoadScene("PlayerEye");
                break;
            default:
                break;
        }
    }
}
