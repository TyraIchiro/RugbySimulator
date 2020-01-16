using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;

public class Draw_Mode : MonoBehaviour, IMixedRealityPointerHandler
{
    bool isalive = false;
    bool tapalive = false;
    GameObject ally;
    ManipulationHandler a_hnd;

    // Start is called before the first frame update
    void Start()
    {
        ally = GameObject.Find("Ally_09");
        a_hnd = ally.GetComponent<ManipulationHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tapalive)
        {

        }
    }

    public void Draw_Stop()
    {
        if (isalive)
        {
            isalive = false;
            a_hnd.enabled = true;
        }
        else
        {
            isalive = true;
            a_hnd.enabled = false;
        }
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {

    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        if (isalive)
        {
            tapalive = true;
        }
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {

    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        if (isalive)
        {
            tapalive = false;
        }
    }
}
