using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D( Collider2D Enemy_Prefab)
    {
        Destroy(Enemy_Prefab.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        // 移動
        // 現在地　＋＝　移動方向　ｘ　移動量　ｘ　１フレームを処理する時間
        // 現在地　transform.position
        // 移動方向　Vector3 の変数を用意
        // 移動量　　float の変数を用意
        // １フレームを処理する時間(1/60) Time.deltaTime

 

        Vector3 dir = Vector3.zero; // 移動方向を保存する変数
        float speed = 10;            // 移動量を保存する変数

 

        // カーソルキーの情報を移動方向に反映
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

 

 

 

        // speed m/s の速度でオブジェクトを移動させる
        transform.position += dir.normalized * speed * Time.deltaTime;

 


    }
}