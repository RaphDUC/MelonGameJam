using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSlider : MonoBehaviour
{

    public Slider hungerSlider;
    public static float hunger;
    public float maxHunger = 100f;
    public static Boolean hungry = true;


    // Start is called before the first frame update
    void Start()
    {
        hunger = maxHunger;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hunger);

        hungerSlider.value = hunger;

        if (hunger >= 0f)
        {
            hunger -= 10f * Time.deltaTime;
            Debug.Log("-10 Hunger");
        }

        if (hunger <= 0f)
        {
            Debug.Log("Starving !");
            hungry = true;
        }
    }
}
