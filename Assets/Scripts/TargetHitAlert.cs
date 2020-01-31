using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHitAlert : MonoBehaviour
{
    [SerializeField] GameObject root;//親を入れる
    [SerializeField] Material yellow;
    [SerializeField] Material white;
    void OnTriggerEnter(Collider cube)
    {
        if(cube.tag == "Cube")
        {
            TargetCount.Instance.TargetHitCount(root.transform.GetSiblingIndex());
            cube.transform.root.gameObject.GetComponent<Renderer>().sharedMaterial = yellow;
        }
    }
    void OnTriggerExit(Collider cube)
    {
        if(cube.tag == "Cube")
        {
            TargetCount.Instance.TargetDisHitCount(root.transform.GetSiblingIndex());
            cube.transform.root.gameObject.GetComponent<Renderer>().sharedMaterial = white;

        }
    }
}
