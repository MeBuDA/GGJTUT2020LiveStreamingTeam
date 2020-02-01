using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCubeSet : MonoBehaviour
{
    [SerializeField] GameObject cube;
    public Vector3[] point = new Vector3[4];
    void Start ()
    {
        for (int i = 0; i < 4; i++)
        {
            point[i] = new Vector3 (Random.Range (-4.0f, 4.0f), 0.2f, Random.Range (-4.0f, 4.0f));
            var cubeClone = Instantiate (cube, point[i], Quaternion.identity);
            cubeClone.gameObject.GetComponent<CubeID> ().cubeID = i;
        }
    }
}