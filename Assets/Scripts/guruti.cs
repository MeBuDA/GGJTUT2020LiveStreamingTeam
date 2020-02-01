using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guruti : MonoBehaviour
{
    void Update ()
    {
        this.transform.Rotate (new Vector3 (0, 90, 0) * Time.deltaTime, Space.World);
    }
}