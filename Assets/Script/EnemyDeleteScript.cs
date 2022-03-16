using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyDeleteScript : MonoBehaviour
{
    [SerializeField]
    static public bool death = false;


    void Awake()
    {
    
        DontDestroyOnLoad(gameObject);
        

    }

    void OnCollisionEnter(Collision collision)
    {

    }



    public void setDeath(bool arg)
    {
        death = arg;
    }

    //OnTriggerEnter関数
    //接触したオブジェクトが引数otherとして渡される
    /*void OnOnCollisionEnter(Collision collision)
    {
        //接触したオブジェクトのタグが"Player"のとき
        if (collision.gameObject.name == "tiger_idle")
        {
            //オブジェクトを消す
            gameObject.SetActive(false);
        }
    }*/






}
