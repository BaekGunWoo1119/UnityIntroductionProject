using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOnKey : MonoBehaviour
{
    public GameObject canvasObject;
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown("u"))
        {
            canvasObject.SetActive(true);
        }
    }
}
