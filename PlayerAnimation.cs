using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;

    void Update()
    {
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D))
        {
            ani.SetInteger("aniIndex", 1);
        }
        else
        {
            ani.SetInteger("aniIndex", 0);
        }
    }
}
