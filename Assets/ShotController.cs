using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void OnTriggerEnter2D( Collider2D Enemy_Prefab)
    {
        Destroy(Enemy_Prefab.gameObject);
        GameObject director = GameObject.Find("GameDirector");
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0.3f,0);

        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
