using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinoReset : MonoBehaviour
{
    [SerializeField] GameObject[] Mino = new GameObject[5];
    [SerializeField] StartCubeSet CubeSet;
    [SerializeField] Text text;
    public static int score = 0;
    public void MinoReSet ()
    {
        CubeSet.CubeReset ();
        MatoSet ();
        score += 100;
        text.text = "スコア : " + score;
    }
    public void MatoSet ()
    {
        for (int i = 0; i < Mino.Length; i++)
        {
            Mino[i].SetActive (false);
        }
        Mino[Random.Range (0, 4)].SetActive (true);
    }
}