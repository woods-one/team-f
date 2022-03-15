using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuckButtonScript : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		
	}
	void Update ()
	{

	}
	// Update is called once per frame
	public void PushButton ()
	{
		SceneManager.LoadScene ("StartScene");
	}
}
//スクリプトの名前とクラスの名前は同じにする