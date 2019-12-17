using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Kick01 : MonoBehaviour
{
    // プレイヤーオブジェクト
    [SerializeField]
    public GameObject Ally_09, Ally_10, Ally_11, Ally_12, Ally_13, Ally_14, Ally_15,
                      Enemy_09, Enemy_10, Enemy_11, Enemy_12, Enemy_13, Enemy_14, Enemy_15,
                      Ball;

    // プレイヤーのアニメーターコンポーネント
    Animator Ally_09Ani, Ally_10Ani, Ally_11Ani, Ally_12Ani, Ally_13Ani, Ally_14Ani, Ally_15Ani,
             Enemy_09Ani, Enemy_10Ani, Enemy_11Ani, Enemy_12Ani, Enemy_13Ani, Enemy_14Ani, Enemy_15Ani,
             BallAni;
    // animatorのstate名
    const string MOVE_ANIM_NAME = "move";
    // アニメーションの開始時間
    float StartTime;
    // プレイヤーの初期位置
    Vector3 Ally_09_startPos, Ally_10_startPos, Ally_11_startPos, Ally_12_startPos, Ally_13_startPos, Ally_14_startPos, Ally_15_startPos,
            Enemy_09_startPos, Enemy_10_startPos, Enemy_11_startPos, Enemy_12_startPos, Enemy_13_startPos, Enemy_14_startPos, Enemy_15_startPos,
            Ball_startPos;

    void Start()
    {
        Ally_09Ani = Ally_09.GetComponent<Animator>();
        Ally_10Ani = Ally_10.GetComponent<Animator>();
        Ally_11Ani = Ally_11.GetComponent<Animator>();
        Ally_12Ani = Ally_12.GetComponent<Animator>();
        Ally_13Ani = Ally_13.GetComponent<Animator>();
        Ally_14Ani = Ally_14.GetComponent<Animator>();
        Ally_15Ani = Ally_15.GetComponent<Animator>();
        Enemy_09Ani = Enemy_09.GetComponent<Animator>();
        Enemy_10Ani = Enemy_10.GetComponent<Animator>();
        Enemy_11Ani = Enemy_11.GetComponent<Animator>();
        Enemy_12Ani = Enemy_12.GetComponent<Animator>();
        Enemy_13Ani = Enemy_13.GetComponent<Animator>();
        Enemy_14Ani = Enemy_14.GetComponent<Animator>();
        Enemy_15Ani = Enemy_15.GetComponent<Animator>();
        BallAni = Ball.GetComponent<Animator>();
        Ally_09Ani.enabled = false;
        Ally_10Ani.enabled = false;
        Ally_11Ani.enabled = false;
        Ally_12Ani.enabled = false;
        Ally_13Ani.enabled = false;
        Ally_14Ani.enabled = false;
        Ally_15Ani.enabled = false;
        Enemy_09Ani.enabled = false;
        Enemy_10Ani.enabled = false;
        Enemy_11Ani.enabled = false;
        Enemy_12Ani.enabled = false;
        Enemy_13Ani.enabled = false;
        Enemy_14Ani.enabled = false;
        Enemy_15Ani.enabled = false;
        BallAni.enabled = false;
        Ally_09_startPos = Ally_09.transform.localPosition;
        Ally_10_startPos = Ally_10.transform.localPosition;
        Ally_11_startPos = Ally_11.transform.localPosition;
        Ally_12_startPos = Ally_12.transform.localPosition;
        Ally_13_startPos = Ally_13.transform.localPosition;
        Ally_14_startPos = Ally_14.transform.localPosition;
        Ally_15_startPos = Ally_15.transform.localPosition;
        Enemy_09_startPos = Enemy_09.transform.localPosition;
        Enemy_10_startPos = Enemy_10.transform.localPosition;
        Enemy_11_startPos = Enemy_11.transform.localPosition;
        Enemy_12_startPos = Enemy_12.transform.localPosition;
        Enemy_13_startPos = Enemy_13.transform.localPosition;
        Enemy_14_startPos = Enemy_14.transform.localPosition;
        Enemy_15_startPos = Enemy_15.transform.localPosition;
        Ball_startPos = Ball.transform.localPosition;
    }

    public void Play_Stop()
    {
        if (Ally_09Ani.enabled && Ally_10Ani.enabled && Ally_11Ani.enabled && Ally_12Ani.enabled && Ally_13Ani.enabled && Ally_14Ani.enabled && Ally_15Ani.enabled &
            Enemy_09Ani.enabled && Enemy_10Ani.enabled && Enemy_11Ani.enabled && Enemy_12Ani.enabled && Enemy_13Ani.enabled && Enemy_14Ani.enabled && Enemy_15Ani.enabled &
            BallAni.enabled)
        {
            Ally_09Ani.enabled = false;
            StartTime = Ally_09Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Ally_10Ani.enabled = false;
            StartTime = Ally_10Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Ally_11Ani.enabled = false;
            StartTime = Ally_11Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Ally_12Ani.enabled = false;
            StartTime = Ally_12Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Ally_13Ani.enabled = false;
            StartTime = Ally_13Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Ally_14Ani.enabled = false;
            StartTime = Ally_14Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Ally_15Ani.enabled = false;
            StartTime = Ally_15Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_09Ani.enabled = false;
            StartTime = Enemy_09Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_10Ani.enabled = false;
            StartTime = Enemy_10Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_11Ani.enabled = false;
            StartTime = Enemy_11Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_12Ani.enabled = false;
            StartTime = Enemy_12Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_13Ani.enabled = false;
            StartTime = Enemy_13Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_14Ani.enabled = false;
            StartTime = Enemy_14Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_15Ani.enabled = false;
            StartTime = Enemy_15Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            BallAni.enabled = false;
            StartTime = BallAni.GetCurrentAnimatorStateInfo(0).normalizedTime;
        }
        else
        {
            Ally_09Ani.enabled = true;
            Ally_10Ani.enabled = true;
            Ally_11Ani.enabled = true;
            Ally_12Ani.enabled = true;
            Ally_13Ani.enabled = true;
            Ally_14Ani.enabled = true;
            Ally_15Ani.enabled = true;
            Enemy_09Ani.enabled = true;
            Enemy_10Ani.enabled = true;
            Enemy_11Ani.enabled = true;
            Enemy_12Ani.enabled = true;
            Enemy_13Ani.enabled = true;
            Enemy_14Ani.enabled = true;
            Enemy_15Ani.enabled = true;
            BallAni.enabled = true;
        }
    }
}
