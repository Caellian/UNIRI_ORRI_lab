using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset = new(0f, 1f, -1f);

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0) + offset;
    }
}
