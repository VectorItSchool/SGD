using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHand : MonoBehaviour
{
   public Vector2 InputVector { get; private set; }

   public Vector3 MousePosition { get; private set; }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        InputVector = new Vector2(horizontal, vertical);
        MousePosition = Input.mousePosition;
    }
}
