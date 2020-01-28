using UnityEngine;
using Es.InkPainter;
using UnityEngine.XR.WSA.Input;

public class Paint : MonoBehaviour
{ 
    [SerializeField]
    private Brush brush;
    public Camera holo_camera;
    private bool pressflag = false;

    private void Start()
    {
        InteractionManager.InteractionSourceUpdated += InteractionManager_SourceUpdated;
        InteractionManager.InteractionSourcePressed += InteractionManager_SourcePressed;
        InteractionManager.InteractionSourceReleased += InteractionManager_SourceReleased;
    }

    private void Update()
    {   

    }

    void InteractionManager_SourceUpdated(InteractionSourceUpdatedEventArgs state)
    {
        if (pressflag == true)
        {
            Vector3 v;
            state.state.sourcePose.TryGetPosition(out v);
            RaycastHit hitInfo;
            if (Physics.Raycast(v, holo_camera.transform.forward, out hitInfo))
            {
                var paintObject = hitInfo.transform.GetComponent<InkCanvas>();
                if (paintObject != null) paintObject.Paint(brush, hitInfo);
            }
        }

    }

    void InteractionManager_SourcePressed(InteractionSourcePressedEventArgs state)
    {
        pressflag = true;
    }

    void InteractionManager_SourceReleased(InteractionSourceReleasedEventArgs state)
    {
        pressflag = false;
    }
}
