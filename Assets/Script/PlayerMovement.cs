using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  /*
   // ボタンを押したときtrue、離したときfalseになるフラグ
  private bool LeftKeyDownFlag = false;
  private void Update()
  {
    if (LeftKeyDownFlag)
    {
      // ボタンが押しっぱなしの状態の時にのみ「Hold」を表示する。
      Debug.Log("Hold");
    }
  }
  
    // ボタンを押したときの処理
  public void OnButtonDown()
  {
    Debug.Log("Down");
    LeftKeyDownFlag = true;
  }

  // ボタンを離したときの処理
  public void OnButtonUp()
  {
    Debug.Log("Up");
    LeftKeyDownFlag = false;
  }
  */


    
     // 加速度
    [SerializeField] private Vector3 _acceleration;

    // 初速度
    [SerializeField] private Vector3 _initialVelocity;

    // 現在速度
    private Vector3 _velocity;

    void Start()
    {
        // 初速度で初期化
        _velocity = _initialVelocity;
    }
  
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //左矢印キーが押されている間、左向きに移動
            this.transform.Translate(0.0f, 0.0f, 0.1f);

            // 加速度の時間積分から速度を求める
            _velocity += _acceleration * Time.deltaTime;

            // 速度の時間積分から位置を求める
            transform.position += _velocity * Time.deltaTime;
            
                 
        }
        else
        {
            _velocity = Vector3.zero;
        }

    }


}
