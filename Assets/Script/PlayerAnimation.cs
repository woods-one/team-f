using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator anim; //インスペクターから取り出せるようにする
    private Rigidbody rb;
    public float upForce = 200f;
    private bool isGround;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey("up")) //上キーが押されたとき前へ歩く
        {
            transform.position += transform.forward * 0.01f;
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        /*if (Input.GetKey("left shift") && Input.GetKey("up")) //Shiftキーかつ上キーが押されている間
        {
            transform.position += transform.forward * 0.03f; //スピードアップ
            anim.SetBool("Running", true); //走るアニメーションをつける
        }*/

        if (Input.GetKeyUp("left shift")) //Shiftキーを離したとき
        {
            anim.SetBool("Running", false); //走るアニメーションをやめる

        }

        

        if (isGround == true)
        {
            if (Input.GetKeyDown("space"))
            {
                anim.SetBool("Jumping", true);
                isGround = false;
                rb.AddForce(new Vector3(0, upForce, 0));
            }
        }

    }

}
