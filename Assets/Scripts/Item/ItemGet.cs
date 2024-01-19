using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    public int count = 0;

    private void Start()
    {
        count = PlayerPrefs.GetInt("countSave");

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if (Input.GetKeyDown("e"))
            {
                count++;
                PlayerPrefs.SetInt("countSave",count);
                print(count);
                Destroy(gameObject);
            }
        }
    }
}
