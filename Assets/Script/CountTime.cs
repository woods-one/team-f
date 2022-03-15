using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour
{
    //public bool isClear = false; //ゴール判定のフラグ

    //時間を表示するためのUI属性のTextを入れる箱
    public UnityEngine.UI.Text TimeText; 

    public static float countTime; //時間用のスクリプト

    void Start()
    {
        countTime = 0;
    }

    void Update()
    {
        countTime += Time.deltaTime; //時間を増やす
        TimeText.text = countTime.ToString("F2"); //小数点2桁で時間をテキストに変換

    }

}
