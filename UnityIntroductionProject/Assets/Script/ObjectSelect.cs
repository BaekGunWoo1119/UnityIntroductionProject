using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectSelect : MonoBehaviour
{
    public GameObject NewObject;

    private float currentScale = 1f;
    // Start is called before the first frame update

    public void CreatePrefab()
    {
        // Prefab을 Scene에 동적으로 생성
        GameObject newPrefab = Instantiate(NewObject, Vector3.zero, Quaternion.identity);
        SetPrefabScale(newPrefab);
    }

    private void SetPrefabScale(GameObject prefab)
    {
        if (prefab != null)
        {
            prefab.transform.localScale = new Vector3(currentScale, currentScale, currentScale);
        }
    }
}
