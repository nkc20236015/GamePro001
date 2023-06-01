using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Controller : MonoBehaviour
{
    Animator anim;
    //public GameObject MyShot_0;//球を打つ
    [SerializeField] float speed;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    void OnTriggerEnter2D( Collider2D other)
    {
        if(other.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            GameObject director =GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTm();

            Debug.Log("あたった");
        }
    }

    void Update()
    {   
        float x = 0 , y = 0;
        x = Input.GetAxis("Horizontal") * Time.deltaTime * speed ;
        y = Input.GetAxis("Vertical") * Time.deltaTime * speed ;
        transform.position = new Vector2(
            //エリア指定して移動する
            Mathf.Clamp(transform.position.x + x, -8.2f, 8.2f),
            Mathf.Clamp(transform.position.y + y, -4.5f, 4.5f)
            );
    } 
}