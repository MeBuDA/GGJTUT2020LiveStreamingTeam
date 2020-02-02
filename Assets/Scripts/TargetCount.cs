using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class TargetCount : SingletonMonoBehaviour<TargetCount>
{
    private bool[] count = new bool[4] { false, false, false,false };//管理
    [SerializeField] MinoReset reset;

    public void TargetHitCount(int id)
    {
        count[id] = true;
    }
    public void TargetDisHitCount(int id)
    {
        count[id] = false;
    }

    void Update()
    {
        if(Array.TrueForAll(count,element　=> element==true))
        {
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = false;
            }
            reset.MinoReSet();
        }
    }
}
