using UnityEngine;

public class CanvasSorting : MonoBehaviour
{
    public Canvas canvas;
    public int sortingOrder = 100;

    private void Start()
    {
        // Canvas의 Sorting Layer와 Order를 설정
        canvas.sortingLayerName = "Default";  // 사용하고 있는 Sorting Layer의 이름으로 변경
        canvas.sortingOrder = sortingOrder;
    }
}