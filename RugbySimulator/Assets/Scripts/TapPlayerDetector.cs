using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class TapPlayerDetector : MonoBehaviour, IMixedRealityPointerHandler
{
    // Start is called before the first frame update
    void Start()
    {
        Monitoring_Field.isTappingPlayer = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        if (Monitoring_Field.moni_mode)
        {
            Debug.Log(this.gameObject);
            Monitoring_Field.isTappingPlayer = this.gameObject;
        }
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
