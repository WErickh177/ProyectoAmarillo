using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody bulletRb;

    public float power = 100f;
    public float lifeTime = 4f;

    private float time = 0f;

    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();

        bulletRb.velocity = this.transform.forward * power;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time >= lifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}