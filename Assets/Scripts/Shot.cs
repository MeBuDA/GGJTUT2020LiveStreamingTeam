using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    void Update ()
    {
        var num = Random.Range (0, 500);

        if (num == 0)
        {

        }
    }
}