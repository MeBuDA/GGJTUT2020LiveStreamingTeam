using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCubeSet : MonoBehaviour
{
    [SerializeField] GameObject cube;
    public Vector3[] point = new Vector3[4];
    [SerializeField] MinoReset minoReset;
    [SerializeField] Material White;
    GameObject[] cubeClone = new GameObject[4];
    void Start ()
    {
        MinoSet ();
        minoReset.MatoSet ();
    }
    public void MinoSet ()
    {
        for (int i = 0; i < 4; i++)
        {
            point[i] = new Vector3 (Random.Range (-4.0f, 4.0f), 0.2f, Random.Range (-4.0f, 4.0f));
            cubeClone[i] = Instantiate (cube, point[i], Quaternion.identity);
            cubeClone[i].gameObject.GetComponent<CubeID> ().cubeID = i;
        }
    }
    public void CubeReset ()
    {
        for (int i = 0; i < 4; i++)
        {
            point[i] = new Vector3 (Random.Range (-4.0f, 4.0f), 0.2f, Random.Range (-4.0f, 4.0f));
            cubeClone[i].transform.position = point[i];
            cubeClone[i].GetComponent<Renderer> ().sharedMaterial = White;
        }
    }
}