using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //インスペクターから指定
    [SerializeField] Animator animator;

    void Start()
    {
        //animatorコンポーネントの取得
        animator = GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        //左矢印キーが押されたとき
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //アニメーターのBool"Running"の発動
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
        }

        //右矢印キーが押されたとき
        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //アニメーターのBool"Walking"の発動
            animator.SetBool("Walking",true);
        }
        else
        {
            animator.SetBool("Running", false);
        }*/
    }
}
