using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//オブジェクトを動かすScript
//Transformの書き換えなので実質細かいワープ
//等速運動
public class MoveTransform : MonoBehaviour
{
    [SerializeField] private Transform pos;//動かしたいオブジェクトをインスペクターからD&D
    [Range(0,1)] [SerializeField] private float speed = 1; //動くスピード　インスペクターから変更可能

    private void Update()
    {
        if(Input.GetKey(KeyCode.S))//押されてる間
        {
            pos.Translate(Vector3.back * speed);
        }
        if(Input.GetKey(KeyCode.W))
        {
            pos.Translate(Vector3.forward * speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            pos.Translate(Vector3.left * speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            pos.Translate(Vector3.right * speed);
        }
    }

}
