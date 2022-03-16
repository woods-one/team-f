using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowGameClearText : MonoBehaviour
{

    //Inspector�ŃL�����N�^�[�ƃS�[���I�u�W�F�N�g�̎w�肪�ł���悤�ɂ���
    [SerializeField] GameObject chara;
    [SerializeField] GameObject gameclear;

    private void Start()
    {
        Time.timeScale = 1;

        chara = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        //�����S�[���I�u�W�F�N�g�̃R���C�_�[�ɐڐG�����Ƃ��̏���
        if(other.CompareTag("Player")){
            if(other.name == chara.name)
            {
                //�Q�[���N���A�e�L�X�g��\�������ăL�����N�^�[���\���ɂ���
                gameclear.GetComponent<Text>();
                gameclear.SetActive(true);
                chara.SetActive(false);
                Time.timeScale = 0;
            };
        }

    }
}
