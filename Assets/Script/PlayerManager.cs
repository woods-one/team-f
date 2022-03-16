using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    //インスペクターから指定
    [SerializeField] Animator anim;
    //[SerializeField] GameObject Player;
    
    private void Start()
    {
        //同じオブジェクトについているコンポーネントを取得
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        /*if (SceneManager.GetActiveScene().name == "BattleScene")
        {
            //BattleSceneのとき，Tigerオブジェクトを非表示
            gameObject.SetActive(false);
        }
        
        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            gameObject.SetActive(true);
        }
        */





        //左矢印キーを押されたら
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetFloat("MoveSpeed", 3.2f);
            //Debug.Log("trueeeeeeee");
        }
        else
        {
            anim.SetFloat("MoveSpeed", 0.0f);
            //anim.SetTrigger("Stop");
            //Debug.Log("falseeeeee");
        }
              
    }

}