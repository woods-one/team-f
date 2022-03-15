using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    //インスペクターから指定
    [SerializeField] Animator anim;

    
    private void Start()
    {
        //同じオブジェクトについているコンポーネントを取得
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        //左矢印キーを押されたら
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetFloat("MoveSpeed", 3.2f);
            Debug.Log("trueeeeeeee");
        }
        else
        {
            //anim.SetFloat("MoveSpeed", 0.0f);
            //anim.SetTrigger("Stop");
            Debug.Log("falseeeeee");
        }
              
    }

}