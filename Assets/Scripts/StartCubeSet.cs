using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCubeSet : MonoBehaviour
{
    [SerializeField] GameObject cube;
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(cube, new Vector3(Random.Range(-4.0f, 4.0f),0.2f,Random.Range(-4.0f, 4.0f)), Quaternion.identity);
        }
    }
}
