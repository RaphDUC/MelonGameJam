using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirstSlider : MonoBehaviour
{

    public Slider thirstSlider;
    public static float thirst;
    public float maxthirst = 100f;


    // Start is called before the first frame update
    void Start()
    {
        thirst = maxthirst;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(thirst);

        thirstSlider.value = thirst;

        if (thirst >= 0f)
        {
            thirst -= 10f * Time.deltaTime;
            Debug.Log("-10 thirst");
        }

        if (thirst <= 0f)
        {
            Debug.Log("Starving !");
        }
    }
}
