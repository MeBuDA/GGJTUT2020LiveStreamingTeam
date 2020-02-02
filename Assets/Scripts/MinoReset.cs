using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinoReset : MonoBehaviour
{
    [SerializeField] GameObject[] Mino = new GameObject[5];
    [SerializeField] StartCubeSet CubeSet;

    public void MinoReSet()
    {
        CubeSet.CubeReset();
        MatoSet();
    }
    public void MatoSet()
    {
        for (int i = 0; i < Mino.Length; i++)
        {
            Mino[i].SetActive(false);
        }
        Mino[Random.Range(0,4)].SetActive(true);
    }
}
