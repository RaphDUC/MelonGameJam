using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TVSlider : MonoBehaviour
{

    public Slider tvSlider;
    public static float tv;
    public float maxtv = 100f;
    public static Boolean needTV = false;


    // Start is called before the first frame update
    void Start()
    {
        tv = maxtv;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(tv);

        tvSlider.value = tv;

        if (tv >= 0f)
        {
            tv -= 10f * Time.deltaTime;
            Debug.Log("-10 tv");
        }

        if (tv <= 0f)
        {
            Debug.Log("Need TV !");
            needTV = true;
        }
    }
}
