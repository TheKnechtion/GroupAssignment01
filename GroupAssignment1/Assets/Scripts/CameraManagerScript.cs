using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCamera;
    public Camera pictureInPicture;
    public Camera SideViewCamera;
    public Camera SplitScreenUpper;
    public Camera SplitScreenLower;

    void Start()
    {
        if (Input.mouseScrollDelta.y != 0) 
        { 
            Vector3 diff = Vector3.forward * Input.mouseScrollDelta.y; 

            if (mainCamera.enabled) 
                mainCamera.transform.Translate(diff); 

            else if (SideViewCamera.enabled) 
                SideViewCamera.transform.Translate(diff); 
            
            else if (SplitScreenLower.enabled) 
                SplitScreenLower.transform.Translate(diff);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSliderValueChanged(float value)
    {
        if (mainCamera.enabled)
            mainCamera.nearClipPlane = value; 

        else if (SideViewCamera.enabled) 
            SideViewCamera.nearClipPlane = value;

        else if (SplitScreenLower.enabled) 
            SplitScreenLower.nearClipPlane = value;
    }

    public void SwitchViews (Dropdown change)
    {
        Debug.LogFormat("{0}:{1}", change.itemText.text,
            change.value);
    }


}
