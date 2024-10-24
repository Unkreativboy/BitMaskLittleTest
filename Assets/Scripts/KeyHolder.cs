using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{

    //Bit values
    public const int KEY4 = 8;
    public const int KEY3 = 4;
    public const int KEY2 = 2;
    public const int KEY1 = 1;

    public int currentKeys = 0;

    private void Update()
    {
        string binaryKeys = Convert.ToString(currentKeys, 2).PadLeft(8, '0');
        Debug.Log(binaryKeys);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "KEY1") currentKeys |= KEY1;
        if(other.gameObject.tag == "KEY2") currentKeys |= KEY2;
        if(other.gameObject.tag == "KEY3") currentKeys |= KEY3;
        if(other.gameObject.tag == "KEY4") currentKeys |= KEY4;
        
    }

}
