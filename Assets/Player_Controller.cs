using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Vector3 pos;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {      
        pos = transform.position;
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        pos.x += x * 0.05f;
        pos.y +=y * 0.05f;

        transform.position = pos;
        //プレイヤーの速度に応じてアニメーション速度を変える
        this.animator.speed = pos.y;
    }
}
