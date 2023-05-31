using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //アニメーターコンポーネントを保存する変数
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //アニメーターコンポーネントをanim変数に保存
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //左右キーの入力情報を取得
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

