﻿using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
public class Receiver : MonoBehaviour, IMixedRealitySourceStateHandler, IMixedRealityInputHandler
{
    IMixedRealityInputSource currentInputSource;
    private uint id;
    private bool isDrag = false;
    GameObject obj;
    public GameObject original;
    private List<GameObject> cubes = new List<GameObject>();

    [Obsolete]
    public void OnInputDown(InputEventData eventData)
    {
        if (!eventData.InputSource.SupportsInputInfo(eventData.SourceId, SupportedInputInfo.Position))
        {
            return;
        }

        GameObject tmp = GameObject.Instantiate(original);
        obj = tmp;
        cubes.Add(tmp);

        currentInputSource = eventData.InputSource;
        id = eventData.SourceId;

        isDrag = true;
        Debug.Log("finger down");
    }

    public void OnInputUp(InputEventData eventData)
    {
        isDrag = false;
        Debug.Log("finger up");
    }

    public void OnSourceDetected(SourceStateEventData eventData)
    {
        Debug.Log("Detected");
    }

    public void OnSourceLost(SourceStateEventData eventData)
    {
        isDrag = false;
        Debug.Log("Lost");
    }

    // Use this for initialization
    void Start()
    {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDrag)
        {
            Vector3 pos;
            currentInputSource.TryGetGripPosition(id, out pos);

            Debug.Log(pos);
            obj.transform.position = pos;
        }
    }


    public void ResetLines()
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            Destroy(cubes[i]);
            cubes[i] = null;
        }
        cubes.Clear();
    }
}*/
