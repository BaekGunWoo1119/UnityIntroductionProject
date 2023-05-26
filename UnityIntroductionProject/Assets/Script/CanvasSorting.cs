using UnityEngine;

public class CanvasSorting : MonoBehaviour
{
    public Canvas canvas;
    public int sortingOrder = 100;

    private void Start()
    {
        // Canvas�� Sorting Layer�� Order�� ����
        canvas.sortingLayerName = "Default";  // ����ϰ� �ִ� Sorting Layer�� �̸����� ����
        canvas.sortingOrder = sortingOrder;
    }
}