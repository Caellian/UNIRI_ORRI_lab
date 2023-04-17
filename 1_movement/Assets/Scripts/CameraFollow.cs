using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset = new(0f, 1f, -1f);

    private GameObject background;
    private GameObject platforms;

    private void Awake()
    {
        player = GameObject.Find("Player");
        background = GameObject.Find("background");
        platforms = GameObject.Find("bgplatforms");
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0) + offset;
        background.transform.position = new Vector3(transform.position.x, transform.position.y, background.transform.position.z);
        platforms.transform.position = new Vector3(transform.position.x * 0.5f, transform.position.y * 0.5f, platforms.transform.position.z);
    }
}
