using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    float num = 7;
    private void OnConCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

        int num = Random.Range(3, 5);
    }
}
