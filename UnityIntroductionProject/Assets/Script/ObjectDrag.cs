using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    private bool isUpdateEnabled = true;
    public void DisableUpdate()
    {
        isUpdateEnabled = false;
    }

    private void OnMouseDrag()
    {
        float distance = Camera.main.WorldToScreenPoint(transform.position).z;

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = objPos;
    }
    void Update()
    {
        if (isUpdateEnabled)
        {
            OnMouseDrag();
            if (Input.GetMouseButtonDown(0))
            {
                DisableUpdate();
            }

            float scaleChange = Input.GetAxis("Mouse ScrollWheel");
            float scaleIncrement = 1f;
            float minScale = 1f;
            float maxScale = 100f;

            float newScale = transform.localScale.x + scaleChange * scaleIncrement;
            newScale = Mathf.Clamp(newScale, minScale, maxScale);

            transform.localScale = new Vector3(newScale, newScale, newScale);
        }
    }
}
