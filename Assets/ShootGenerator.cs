using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGenerator : MonoBehaviour
{
    public GameObject Shoot_Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            GameObject MyShot_0 = 
                Instantiate(Shoot_Prefab);
            MyShot_0.GetComponent<ShotController>().transform.Translate(0,0.3f,0);
        }
    }
}
