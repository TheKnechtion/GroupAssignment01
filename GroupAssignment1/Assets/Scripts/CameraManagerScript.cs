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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSliderValueChanged(float value)
    {
        Debug.LogFormat("Slider:{0}", value);
    }

    public void SwitchViews (Dropdown change)
    {
        Debug.LogFormat("{0}:{1}", change.itemText.text,
            change.value);
    }


}
