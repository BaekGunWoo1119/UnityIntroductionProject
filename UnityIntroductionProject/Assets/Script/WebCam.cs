using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{

    public Renderer display;
    WebCamTexture camTexture;
    private int currentIndex = 1;

    private void Start()
    {
        if (camTexture != null)
        {
            display.material.mainTexture = null;
            camTexture.Stop();
            camTexture = null;
        }
        WebCamDevice device = WebCamTexture.devices[currentIndex];
        camTexture = new WebCamTexture(device.name);
        display.material.mainTexture = camTexture;
        camTexture.requestedFPS = 60;
        camTexture.Play();
    }
    public void StopCam()
    {
        camTexture.Stop();
    }
}