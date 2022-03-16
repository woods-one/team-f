using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Retention : MonoBehaviour{

    //インスタンスが存在するか？

    static bool existsInstance = false;

    void Awake(){

        if(existsInstance){

            Destroy(gameObject);

            return;

        }
/*
    void OnCollisionEnter(Collision otherObj)
    {
        if(otherObj.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
*/
        existsInstance = true;

        DontDestroyOnLoad(gameObject);

    }

    

/*
    public GameObject enemy;

    if (otherObj.gameObject.tag == "enemy") {
        Destroy(gameObject);
    }
/*
    GameObject obj = GameObject.Find ("Zombie leg v2");
        // 指定したオブジェクトを削除
        Destroy (obj);

    GameObject obj = GameObject.Find ("tiger_idle ");
        Destroy (obj);
*/
}