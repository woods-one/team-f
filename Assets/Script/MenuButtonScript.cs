using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonScript : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    bool IsPause;
    void Start()
    {
       IsPause = false;
    }
    public void Push()
    {
        if (!IsPause)
        {
            Debug.Log(IsPause);
            Time.timeScale = 0;
            menuPanel.SetActive(true);
            IsPause = true;
            return;
        }
        if(IsPause)
        {
            Debug.Log(IsPause);
            Time.timeScale = 1;
            menuPanel.SetActive(false);
            IsPause = false;
            return;
        }
    }
}
//publicだとオブジェクトをアタッチできるようになる
//[SerializeField]を使った方がいい
