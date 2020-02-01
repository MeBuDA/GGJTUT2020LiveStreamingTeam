using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletKill : MonoBehaviour
{
    void OnTriggerEnter (Collider kabe)
    {
        if (kabe.tag == "kabe")
        {
            Destroy (this.gameObject);
        }
    }
}