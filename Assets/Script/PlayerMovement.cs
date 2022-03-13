using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {

    }

  
    void FixedUpdate()
    {
        /*if(Input.GetKey(KeyCode.LeftArrow))
        {
            //左矢印キーが押されている間、左向きに移動
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }*/

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //左矢印キーが押されている間、左向きに移動
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }
    }
}
