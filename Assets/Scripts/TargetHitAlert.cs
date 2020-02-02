using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHitAlert : MonoBehaviour
{
    [SerializeField] GameObject root;//親を入れる
    [SerializeField] Material yellow;
    [SerializeField] Material white;
    [SerializeField] CriAtomSource matoCAS;
    void OnTriggerEnter(Collider cube)
    {
        if(cube.tag == "Cube")
        {
            TargetCount.Instance.TargetHitCount(root.transform.GetSiblingIndex());
            var cubeRoot = cube.transform.root.gameObject;
            cubeRoot.GetComponent<Renderer>().sharedMaterial = yellow;
            cubeRoot.GetComponent<Transform>().position = this.transform.position;
            matoCAS.GetComponent<CriAtomSource>().Play();
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
