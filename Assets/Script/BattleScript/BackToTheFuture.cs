using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToTheFuture : MonoBehaviour
{
      public Slider slider;
      private bool maxValue;
      private bool isClicked;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClicked = true;

            if(slider.value > 3.5)
            {


                Transform forwerdwarp = GameObject.FindGameObjectWithTag("Player").transform;

                forwerdwarp.position = new Vector3(forwerdwarp.position.x - 9f, forwerdwarp.position.y, forwerdwarp.position.z);

                Debug.LogWarning(GameObject.FindGameObjectWithTag("Player").name);

                SceneManager.LoadScene("GameScene");
            }

            if (Input.GetMouseButtonDown(0))
            {
                isClicked = true;
                
                if (slider.value == 5)
                {
                    maxValue = true;
                }
        
                if (slider.value == 1)
                {
                    maxValue = false;
                }
     
                //フラグによるスライダー値の増減
                if(maxValue)
                {
                    slider.value -= 0.1f;
                }
                else
                {
                    slider.value += 0.1f;
                }

            }
        }
    }
}
