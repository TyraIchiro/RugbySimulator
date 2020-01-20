using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;

public class Draw_Mode : MonoBehaviour, IMixedRealityPointerHandler
{
    public static bool isalive;
    public static GameObject obj;
    public static TrailRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        isalive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isalive)
        {
            /*
            obj = Monitoring_Field.isTappingPlayer;
            line = obj.GetComponent<TrailRenderer>();
            line.enabled = true;
            */
        }
    }

    public void Draw_Stop()
    {
        Monitoring_Field.Moni_Field();
        if (isalive)
        {
            line.enabled = false;
            isalive = false;
            Monitoring_Field.isTappingPlayer = null;
        }
        else
        {
            isalive = true;
            obj = GameObject.Find("Ground");
            line = obj.GetComponent<TrailRenderer>();
        }
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {

    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {

    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        
    }
}
