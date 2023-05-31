using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�A�j���[�^�[�R���|�[�l���g��ۑ�����ϐ�
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //�A�j���[�^�[�R���|�[�l���g��anim�ϐ��ɕۑ�
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //���E�L�[�̓��͏����擾
        float y = Input.GetAxisRaw("Horizontal");

        if(y == 0)
        {
            anim.Play("Player");
        }
        else if (y == 1)
        {
            anim.Play("PlayerR");
        }
        else if (y == -1)
        {
            anim.Play("PlayerL");
        }
    }
}

