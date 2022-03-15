using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGameOverText : MonoBehaviour
{
    //Inspectorでキャラクターとゴールオブジェクトの指定ができるようにする
    [SerializeField] GameObject chara;
    [SerializeField] GameObject gameover;

  
        private void OnTriggerEnter(Collider other)
    {
        //もしゴールオブジェクトのコライダーに接触したときの処理
        if (other.name == chara.name)
        {
            //ゲームオーバーテキストを表示させてキャラクターを非表示にする
            gameover.GetComponent<Text>();
            gameover.SetActive(true);
            chara.SetActive(false);
        }

    }
}
