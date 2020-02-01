using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHitAlert : MonoBehaviour
{
    [SerializeField] GameObject root;//親を入れる
    [SerializeField] Material yellow;
    [SerializeField] Material white;
    [SerializeField] CriAtomSource mato_CAS;
    void OnTriggerEnter(Collider cube)
    {
        if(cube.tag == "Cube")
        {
            TargetCount.Instance.TargetHitCount(root.transform.GetSiblingIndex());
            var cubeRoot = cube.transform.root.gameObject;
            cubeRoot.GetComponent<Renderer>().sharedMaterial = yellow;
            cubeRoot.GetComponent<Transform>().position = this.transform.position;
            mato_CAS.Play();
            //cube.transform.GetChild(0).GetComponent<CriAtomSource>().Play();
            //block_CAS = cube.GetComponent<CriAtomSource>();//.Play();
            //block_CAS.Play();
            //Debug.Log(cube.name);
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
