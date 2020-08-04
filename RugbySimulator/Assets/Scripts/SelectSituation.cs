using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSituation : MonoBehaviour
{
    public GameObject Dec_box;
    public GameObject Load;
    SetSituation Situation;
    SelectAnimation Anime;
    public int[] situ;

    // Start is called before the first frame update
    void Start()
    {
        Situation = Dec_box.GetComponent<SetSituation>();
        Anime = Load.GetComponent<SelectAnimation>();
        situ = new int[3] {Situation.A, Situation.E, Situation.S};
        Anime.sel_ani(situ);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
