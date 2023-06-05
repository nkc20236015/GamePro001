using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Moving2 : MonoBehaviour
{
    GameObject Moving;
    private float countup = 0.0f;

    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        countup += Time.deltaTime;

        timeText.text = countup.ToString("f1")+"m";
    }
}
