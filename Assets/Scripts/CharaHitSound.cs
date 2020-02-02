using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaHitSound : MonoBehaviour{
    [SerializeField] private CriAtomSource playerCAS;
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag.Equals("kabe")){
            CriAtomEx.SetGameVariable("myHit", 1f);
            playerCAS.Play();
        }
        else if(other.gameObject.tag.Equals("CubeSoto")){
            CriAtomEx.SetGameVariable("myHit", 0f);
            playerCAS.Play();
            //Debug.Log("Hit");
        }
    }
}
