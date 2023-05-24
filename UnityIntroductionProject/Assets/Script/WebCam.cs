using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{

    public RawImage display;
    WebCamTexture camTexture;
    private int currentIndex = 1;


    private void Start()
    {
        if (camTexture != null)
        {
            display.texture = null;
            camTexture.Stop();
            camTexture = null;
        }
        WebCamDevice device = WebCamTexture.devices[currentIndex];
        camTexture = new WebCamTexture(device.name);
        display.texture = camTexture;
        camTexture.Play();
    }
    // Update is called once per frame
    public void StopCam()
    {
        camTexture.Stop();
    }
}