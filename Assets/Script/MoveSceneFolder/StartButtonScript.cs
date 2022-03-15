using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UI.text;

public class StartButtonScript : MonoBehaviour 
{
	public GameObject inputGameObject;
	public InputField inputField;
	string player;
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
		if(inputGameObject.GetComponent<Text>().text == "")
		{
			player =  "名無しの李徴子";
			Debug.Log(player);
		}
		else
		{
			player = inputField.text;
			Debug.Log(player);
		}
			SceneManager.LoadScene ("GameScene");
	}	
}
//スクリプトの名前とクラスの名前は同じにする