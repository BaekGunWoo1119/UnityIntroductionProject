using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void VR_Scene()
    {
        SceneManager.LoadScene("Char_Info");

    }

    public void AR_Scene()
    {
        SceneManager.LoadScene("AR_Info");

    }

    public void Main_Scene()
    {
        SceneManager.LoadScene("MainScene");
    }
}