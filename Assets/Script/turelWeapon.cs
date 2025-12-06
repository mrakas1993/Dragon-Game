using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turelWeapon : MonoBehaviour
{
    [Header("настройка стрельбы")]
    public Transform shotpos;
    public GameObject bullet;
    public float firetime = 3f;
    public Vector2 shotdirection = Vector2.left;

    private float nextfiretime;
    // Start is called before the first frame update
    void Start()
    {
        //shotdirection = shotdirection.normalized;
        //float angel = Mathf.Atan2(shotdirection.y, shotdirection.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angel, Vector3.forward);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextfiretime)
        {
            Shoot();
            nextfiretime = Time.time + 1f/firetime;
        }


    }
    void Shoot()
    {
        Instantiate(bullet, shotpos.position, shotpos.rotation);
    }
}
