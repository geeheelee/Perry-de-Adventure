using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public RawImage[] itemUIImages; // RawImage 배열

    private int currentItemIndex = 0;

    void Start()
    {
        // 배열 초기화 (Inspector에서 배열 크기 설정)
        for (int i = 0; i < itemUIImages.Length; i++)
        {
            itemUIImages[i].enabled = false;
        }
    }

    public void ItemPickUp()
    {
        if (itemUIImages != null && currentItemIndex < itemUIImages.Length)
        {
            itemUIImages[currentItemIndex].enabled = true;
            currentItemIndex++;

            // 모든 이미지를 표시한 경우, 초기화
            if (currentItemIndex >= itemUIImages.Length)
            {
                Debug.Log("미션 성공");
            }
        }
    }
}