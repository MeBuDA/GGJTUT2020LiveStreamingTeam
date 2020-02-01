using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitSound : MonoBehaviour{
    [SerializeField] private CriAtomSource CAS_Player;
    void Start(){
        
    }

    void Update(){
        
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag.Equals("kabe")){
            CriAtomEx.SetGameVariable("myHit",1f);
            //Debug.Log("kabe hit");
            CAS_Player.Play();
        }
        if(other.gameObject.tag.Equals("Cube")){
            CriAtomEx.SetGameVariable("myHit",0f);
            //Debug.Log("cube hit");
            CAS_Player.Play();
        }
        //Debug.Log("いちちクリエイター");
    }
}