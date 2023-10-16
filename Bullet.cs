using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed;
    public GameObject objectToSpawn;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up.normalized * speed * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down.normalized * speed * Time.deltaTime);
        }

    }
}
