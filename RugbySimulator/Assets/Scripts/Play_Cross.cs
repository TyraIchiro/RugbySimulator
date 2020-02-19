using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Cross : MonoBehaviour
{
    // プレイヤーオブジェクト
    [SerializeField]
    GameObject Ally_10,Ally_12, Ball, Enemy_10, Enemy_12;

    // プレイヤーのアニメーターコンポーネント
    Animator Ally_10Ani, Ally_12Ani, BallAni, Enemy_10Ani, Enemy_12Ani;
    TrailRenderer Ally_10Tra, Ally_12Tra;
    // animatorのstate名
    const string MOVE_ANIM_NAME = "move";
    // アニメーションの開始時間
    float StartTime;
    // プレイヤーの初期位置
    Vector3 Ally_10_startPos, Ally_12_startPos, Ball_startPos, Enemy_10_startPos, Enemy_12_startPos;

    void Start()
    {
        Ally_10 = GameObject.Find("Ally_10");
        Ally_12 = GameObject.Find("Ally_12");
        Ball = GameObject.Find("Ball");
        Enemy_10 = GameObject.Find("Enemy_10");
        Enemy_12 = GameObject.Find("Enemy_12");

        Ally_10Ani = Ally_10.GetComponent<Animator>();
        Ally_12Ani = Ally_12.GetComponent<Animator>();
        BallAni = Ball.GetComponent<Animator>();
        Enemy_10Ani = Enemy_10.GetComponent<Animator>();
        Enemy_12Ani = Enemy_12.GetComponent<Animator>();
        Ally_10Tra = Ally_10.GetComponent<TrailRenderer>();
        Ally_12Tra = Ally_12.GetComponent<TrailRenderer>();
        Ally_10Ani.enabled = false;
        Ally_12Ani.enabled = false;
        BallAni.enabled = false;
        Enemy_10Ani.enabled = false;
        Enemy_12Ani.enabled = false;
        Ally_10Tra.enabled = false;
        Ally_12Tra.enabled = false;
        Ally_10_startPos = Ally_10.transform.localPosition;
        Ally_12_startPos = Ally_12.transform.localPosition;
        Ball_startPos = Ball.transform.localPosition;
        Enemy_10_startPos = Enemy_10.transform.localPosition;
        Enemy_12_startPos = Enemy_12.transform.localPosition;
    }

    public void Play()
    {
        if (Ally_10Ani.enabled == false)
        {
            Ally_10Ani.enabled = true;
            //Ally_10Ani.Play(MOVE_ANIM_NAME, 0, StartTime);
            Ally_12Ani.enabled = true;
            //Ally_12Ani.Play(MOVE_ANIM_NAME, 0, StartTime);
            BallAni.enabled = true;
            //BallAni.Play(MOVE_ANIM_NAME, 0, StartTime);
            Enemy_10Ani.enabled = true;
            Enemy_12Ani.enabled = true;
            Ally_10Tra.enabled = true;
            Ally_12Tra.enabled = true;
        }
    }

    public void Stop()
    {
        if (Ally_10Ani.enabled)
        {
            Ally_10Ani.enabled = false;
            StartTime = Ally_10Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Ally_12Ani.enabled = false;
            StartTime = Ally_12Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            BallAni.enabled = false;
            StartTime = BallAni.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_10Ani.enabled = false;
            StartTime = Enemy_10Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            Enemy_12Ani.enabled = false;
            StartTime = Enemy_12Ani.GetCurrentAnimatorStateInfo(0).normalizedTime;
            //Ally_10Tra.enabled = false;
            //Ally_12Tra.enabled = false;
        }
    }

    /*
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
            Ally_10Tra.enabled = false;
            Ally_12Tra.enabled = false;
        } else
        {
            Ally_10Ani.enabled = true;
            //Ally_10Ani.Play(MOVE_ANIM_NAME, 0, StartTime);
            Ally_12Ani.enabled = true;
            //Ally_12Ani.Play(MOVE_ANIM_NAME, 0, StartTime);
            BallAni.enabled = true;
            //BallAni.Play(MOVE_ANIM_NAME, 0, StartTime);
            Ally_10Tra.enabled = true;
            Ally_12Tra.enabled = true;
        }
    }
    */
}
