using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurferInputController : MonoBehaviour
{
    private float horizontalValue;

    public float HorizontalValue
    {
        get { return horizontalValue; }
    }

    
    private void Update()
    {
        HandleSurferHorizontalInput();
    }


    private void HandleSurferHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    }
}
