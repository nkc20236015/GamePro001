using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Animator anim;
    //public GameObject MyShot_0;//‹…‚ð‘Å‚Â
    [SerializeField] float speed;
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    void OnTriggerEnter2D( Collider2D Enemy_Prefab)
    {
        Destroy(Enemy_Prefab.gameObject);
        GameObject director =GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseTm();
    }

    void Update()
    {   
        float x = 0 , y = 0;
        x = Input.GetAxis("Horizontal") * Time.deltaTime * speed ;
        y = Input.GetAxis("Vertical") * Time.deltaTime * speed ;
        transform.position = new Vector2(
            //ƒGƒŠƒAŽw’è‚µ‚ÄˆÚ“®‚·‚é
            Mathf.Clamp(transform.position.x + x, -8.2f, 8.2f),
            Mathf.Clamp(transform.position.y + y, -4.5f, 4.5f)
            );
    } 
}