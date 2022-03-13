using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGameClearText : MonoBehaviour
{

    //Inspectorでキャラクターとゴールオブジェクトの指定ができるようにする
    [SerializeField] GameObject chara;
    [SerializeField] GameObject gameclear;

    private void OnTriggerEnter(Collider other)
    {
        //もしゴールオブジェクトのコライダーに接触したときの処理
        if(other.name == chara.name)
        {
            //ゲームクリアテキストを表示させてキャラクターを非表示にする
            gameclear.GetComponent<Text>();
            gameclear.SetActive(true);
            chara.SetActive(false);
        }
    }
}
