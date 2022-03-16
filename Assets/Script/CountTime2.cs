using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime2 : MonoBehaviour
{
    public static float CountTime_2;
    //時間を表示するためのUI属性のTextを入れる箱
    public UnityEngine.UI.Text TimeText2;

    void Start()
    {
        //CountTimeスクリプトのげｒCountTimeメソッドの値を参照
        CountTime_2 = CountTime.getCountTime();

    }

    void FixedUpdate()
    {
        CountTime_2 += Time.deltaTime; //時間を増やす
        TimeText2.text = CountTime_2.ToString("F2"); //小数点2桁で時間をテキストに変換
    }

    public static float getCountTime2()
    {
        return CountTime_2;
    }

}
