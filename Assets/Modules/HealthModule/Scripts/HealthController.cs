using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    private Slider health_bar;

    private void Start()
    {
        health_bar = gameObject.GetComponent<Slider>();
        health_bar.interactable = false;
        health_bar.maxValue = 100;
        health_bar.value = 50;
    }

    public void HealthBarChange(float count)
    {
        health_bar.value += count;
    }

}
