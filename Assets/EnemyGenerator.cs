using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_Prefab;
    float span = 0.8f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_Prefab);
            float py = Random.Range(-4.5f,4.5f);
            go.transform.position = new Vector3(10,py,0);
        }
    }
}
