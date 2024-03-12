using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    private float systemGameTime = 300.0f;
    public float itemTime = 30.0f;
    public float playTime;
    IEnumerator EndGameAfterDelay()
    {
        yield return new WaitForSeconds(playTime);
        Debug.Log("게임 종료!");
        Application.Quit();
        //여기서 다음 씬(게임오버 화면)으로 넘어가면 됨
    }
    // Start is called before the first frame update
    void Start()
    {
        playTime = systemGameTime;
        StartCoroutine(EndGameAfterDelay());
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Time"))
        {
            playTime += itemTime;

            other.gameObject.SetActive(false);
        }
    }
    void Update()
    {
        playTime -= Time.deltaTime;
    }
}
