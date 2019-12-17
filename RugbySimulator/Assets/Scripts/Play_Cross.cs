using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Cross : MonoBehaviour
{
    // プレイヤーオブジェクト
    [SerializeField]
    GameObject Ally_10,Ally_12, Ball;

    // プレイヤーのアニメーターコンポーネント
    Animator Ally_10Ani, Ally_12Ani, BallAni;
    // animatorのstate名
    const string MOVE_ANIM_NAME = "move";
    // アニメーションの開始時間
    float StartTime;
    // プレイヤーの初期位置
    Vector3 Ally_10_startPos, Ally_12_startPos, Ball_startPos;

    void Start()
    {
        Ally_10 = GameObject.Find("Ally_10");
        Ally_12 = GameObject.Find("Ally_12");
        Ball = GameObject.Find("Ball");

        Ally_10Ani = Ally_10.GetComponent<Animator>();
        Ally_12Ani = Ally_12.GetComponent<Animator>();
        BallAni = Ball.GetComponent<Animator>();
        Ally_10Ani.enabled = false;
        Ally_12Ani.enabled = false;
        BallAni.enabled = false;
        Ally_10_startPos = Ally_10.transform.localPosition;
        Ally_12_startPos = Ally_12.transform.localPosition;
        Ball_startPos = Ball.transform.localPosition;
    }

    public void Play_Stop()
    {
        if (Ally_10Ani.enabled && Ally_12Ani.enabled && BallAni.enabled)
        {
            Ally_10Ani.enabled = false;
            StartTime = Ally_10Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Ally_12Ani.enabled = false;
            StartTime = Ally_12Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            BallAni.enabled = false;
            StartTime = BallAni.GetCurrentAnimatorStateInfo(0).normalizedTime;
        } else
        {
            Ally_10Ani.enabled = true;
            //Ally_10Ani.Play(MOVE_ANIM_NAME, 0, StartTime);
            Ally_12Ani.enabled = true;
            //Ally_12Ani.Play(MOVE_ANIM_NAME, 0, StartTime);
            BallAni.enabled = true;
            //BallAni.Play(MOVE_ANIM_NAME, 0, StartTime);
        }
    }
}
