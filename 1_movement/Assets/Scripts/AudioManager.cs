using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip Sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            AudioSource.PlayClipAtPoint(Sound, transform.position);
            Destroy(gameObject);
        }
    }
}
