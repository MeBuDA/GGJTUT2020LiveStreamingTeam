using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private string transitionTarget; //遷移先シーンを指定
    public void Transition ()
    {
        SceneManager.LoadScene (transitionTarget); //指定したシーンに遷移
        Resources.UnloadUnusedAssets ();
        System.GC.Collect ();
    }
}