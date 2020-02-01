using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] CharaHeart HP;
    void Update()
    {
        if(HP.Heart<=0)
        {
            SceneManager.LoadScene ("Start");
        }
    }
}
