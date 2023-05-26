using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public string hyperlinkURL; // 열고자 하는 하이퍼링크 URL

    public void OpenLink()
    {
        Application.OpenURL(hyperlinkURL);
    }
   
}
