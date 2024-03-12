using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 offset = new Vector3(4.0f, 4.0f, 5.0f);
    public float followSpeed = 0.15f;

    private GameObject player;

    void Awake()
    {
        player = GameObject.Find("PERRY");
    }

    void FixedUpdate()
    {
        Vector3 camera_pos = player.transform.position + offset;
        Vector3 lerp_pos = Vector3.Lerp(transform.position, camera_pos, followSpeed);
        transform.position = lerp_pos;
        //transform.LookAt(player.transform);
    }
}
