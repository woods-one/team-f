using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//toはクラス名に必要ないかと思われます
public class BacktoGame : MonoBehaviour
{
    //Start、Updateメソッドは必要なければ消しましょう
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //謎の空白があるので消しましょう
    public void PushBack()
	{
		SceneManager.LoadScene ("GameScene");
	}	
}
