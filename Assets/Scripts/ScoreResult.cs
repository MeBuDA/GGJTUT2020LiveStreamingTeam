using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    [SerializeField] Text text;
    void Start()
    {
        text.text = "スコア : " + MinoReset.score;
    }
}
