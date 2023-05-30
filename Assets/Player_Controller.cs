using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public GameObject MyShot_0;//球を打つ
    [SerializeField] float speed;
    void Start()
    {
        
    }

    void OnTriggerEnter2D( Collider2D Enemy_Prefab)
    {
        Destroy(Enemy_Prefab.gameObject);
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        
         transform.position = new Vector2(
             //エリア指定して移動する
             Mathf.Clamp( transform.position.x + moveX, -8.2f, 8.2f ),
             Mathf.Clamp( transform.position.y + moveY, -4.5f, 4.5f )
             );    
    } 
}