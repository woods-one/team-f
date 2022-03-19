using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class StrangeVoice : MonoBehaviour
{
      public Slider slider;
      private bool maxValue;//isを頭につけたほうがいいかと思われます
      private bool isClicked;
 
    void Start()
    {
        slider.value = 0;
        maxValue = false;
        isClicked = false;
    }
 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClicked = true;
        }
 
        //クリックされていなければ実行
        if(!isClicked) 
        {
            //5に達した場合と、0に戻った場合のフラグ切替え
            if (slider.value == 5)//マジックナンバーなので変数に一度代入して条件式の中に書きましょう
            {
                maxValue = true;
            }
        
            if (slider.value == 1)//マジックナンバーなので変数に一度代入して条件式の中に書きましょう
            {
                maxValue = false;
            }
 
            //フラグによるスライダー値の増減
            if(maxValue)
            {
                slider.value -= 0.1f;//マジックナンバーなので変数に一度代入しましょう
            }
            else
            {
                slider.value += 0.1f;//マジックナンバーなので変数に一度代入しましょう
            }
        }
    }
}
