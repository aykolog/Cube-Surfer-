using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotator : MonoBehaviour
{
    public float zDonmeHizi = 50f; 

    void Update()
    {
        // Y ekseninde dönme
        RotateObject();
    }

    void RotateObject()
    {
        float zDonmeMiktari = zDonmeHizi * Time.deltaTime;
        transform.Rotate(new Vector3(0,01), zDonmeMiktari); 
    }
}
