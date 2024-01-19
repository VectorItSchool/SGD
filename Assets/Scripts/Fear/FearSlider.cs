using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearSlider : MonoBehaviour
{
    private Slider slider;
    public static int current_value = 100;
    public int max_value = 100;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.maxValue = max_value;
        slider.value = current_value;
    }

    private void Update()
    {
        if (slider.value > 0)
        {
            slider.value = current_value;
        }
        else
        {
            print("end");
        }

    }

}
