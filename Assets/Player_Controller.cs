using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public GameObject MyShot_0;//‹…‚ð‘Å‚Â
    Animator animator;
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
        if (Input.GetAxis("Horizontal") == 1)
        {
            this.animator.SetTrigger("Player_Up_Animation");
        }
        else if(Input.GetAxis("Horizontal") == 0)
        {
            this.animator.SetTrigger("Player_down_Animation");
        }
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        
         transform.position = new Vector2(
             //ƒGƒŠƒAŽw’è‚µ‚ÄˆÚ“®‚·‚é
             Mathf.Clamp( transform.position.x + moveX, -8.2f, 8.2f ),
             Mathf.Clamp( transform.position.y + moveY, -4.5f, 4.5f )
             );    
    } 
}