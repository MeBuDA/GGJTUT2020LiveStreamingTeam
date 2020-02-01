using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveD : MonoBehaviour
{
    [Range (0, 1)][SerializeField] float speed;
    void Update ()
    {
        this.transform.Translate (Vector3.left  * speed);
        if (this.transform.position.x > 4 || this.transform.position.x < -4) speed = -speed;
    }
}