using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject TmGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.TmGauge = GameObject.Find("TmGauge");
    }

    public void DecreaseTm()
    {
        this.TmGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}