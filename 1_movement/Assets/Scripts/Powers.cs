using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    [SerializeField] Transform FirePoint;

    [SerializeField] GameObject Bullet;
    [SerializeField] AudioClip Sound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        var d = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        AudioSource.PlayClipAtPoint(Sound, transform.position);
    }
}
