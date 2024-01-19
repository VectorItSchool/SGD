using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fear : MonoBehaviour
{
    public float wait_second = 0.1f;
    void Start()
    {
        StartCoroutine(Timer());
    }

    

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(wait_second);
        FearSlider.current_value -= 1;
        StartCoroutine(Timer());
    }

}
