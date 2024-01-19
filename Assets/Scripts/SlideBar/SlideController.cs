using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SlideController : MonoBehaviour
{
    private Slider slidebar;

    public float max_value = 100;
    public float min_value = 0;
    public float value = 100;
    public bool interactable = false;

    private void Start()
    {
        slidebar = gameObject.GetComponent<Slider>();
        slidebar.maxValue = max_value;
        slidebar.minValue = min_value;
        slidebar.interactable = interactable;
    }

    private void Update()
    {
        slidebar.value = value;
    }

}
