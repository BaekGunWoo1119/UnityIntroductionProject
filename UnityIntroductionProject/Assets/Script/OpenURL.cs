using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public string hyperlinkURL; // ������ �ϴ� �����۸�ũ URL

    public void OpenLink()
    {
        Application.OpenURL(hyperlinkURL);
    }
   
}
