using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour
{
    //時間を表示するためのUI属性のTextを入れる箱
    public UnityEngine.UI.Text TimeText; 

    public static float countTime; //時間用のスクリプト

    void Start()
    {
        countTime = CountTime2.getCountTime2();
    }

    void FixedUpdate()
    {
        countTime += Time.deltaTime; //時間を増やす
        TimeText.text = countTime.ToString("F2"); //小数点2桁で時間をテキストに変換

    }

    public static float getCountTime()
    {
        return countTime;
    }

}
