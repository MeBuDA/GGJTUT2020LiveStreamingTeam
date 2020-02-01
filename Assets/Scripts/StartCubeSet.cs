using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCubeSet : MonoBehaviour
{
    [SerializeField] GameObject cube;
    public Vector3[] point { get; set; }
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            point[i] = new Vector3(Random.Range(-4.0f, 4.0f),0.2f,Random.Range(-4.0f, 4.0f));
            Instantiate(cube, point[i] , Quaternion.identity);
        }

    }
}
