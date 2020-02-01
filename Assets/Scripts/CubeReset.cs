using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeReset : MonoBehaviour
{
    void OnCollisionEnter (Collision kabe)
    {
        var GameManager = GameObject.Find ("GameManager");
        var cubeSet = GameManager.GetComponent<StartCubeSet> ();
        var id = GetComponent<CubeID> ().cubeID;
        if (kabe.gameObject.tag == "kabe")
        {
            this.transform.position = cubeSet.point[id];
        }
    }
}