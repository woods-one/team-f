using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtleSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // ゲームオブジェクト同士が接触したタイミングで実行
public void OnCollisionEnter(Collision collision)
{
        if (collision.gameObject.name == "Zombie leg v2") 
        {
            Debug.Log("aaa");
            // battlesceneへ移行
            SceneManager.LoadScene("BattleScene");
        }   
}

}
