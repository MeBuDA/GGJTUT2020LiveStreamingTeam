using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaKill : MonoBehaviour
{
    [SerializeField] CharaHeart CharaHeart;
    [SerializeField] GameObject[] HP = new GameObject[3];
    void OnTriggerEnter (Collider bulletkill)
    {
        if(CharaHeart.Heart<0)return;
        if(bulletkill.gameObject.tag == "Bullet")
        {
            CharaHeart.Heart--;//HPが減る
            HP[CharaHeart.Heart].SetActive(false);
        }
    }
}
