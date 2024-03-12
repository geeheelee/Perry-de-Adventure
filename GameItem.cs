using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItem : MonoBehaviour
{
    public ItemManager itemManager;
    public TimerUI timerUI;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item"))
        {
            itemManager.ItemPickUp();

            other.gameObject.SetActive(false);
        }

        else if (other.CompareTag("Time"))
        {
            timerUI.TimeItem();
            other.gameObject.SetActive(false);
        }
    }
}
