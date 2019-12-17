using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Player : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        Vector3 posA = player.transform.position;
        Vector3 posB = this.transform.position;
        float dis = Vector3.Distance(posA, posB);
        // Debug.Log("Distance : " + dis);
        if(dis <= 0.03)
        {
            //親オブジェクトを取得
            transform.parent = player.transform;
        }
    }
}
