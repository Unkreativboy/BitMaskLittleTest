using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{

    private int requiredKey;

    private void OnCollisionEnter(Collision collision)
    {

        //Checks if you have all the keys required to Open the Door
        if((collision.gameObject.GetComponent<KeyHolder>().currentKeys & requiredKey) == requiredKey)
        {

            collision.gameObject.GetComponent<KeyHolder>().currentKeys &= ~requiredKey;
            gameObject.GetComponent<BoxCollider>().isTrigger = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = false;
    }


    private void Start()
    {
        if (gameObject.tag == "KEYDOOR1") requiredKey = KeyHolder.KEY1;
        if (gameObject.tag == "KEYDOOR2") requiredKey = KeyHolder.KEY2;
        if (gameObject.tag == "KEYDOOR3") requiredKey = KeyHolder.KEY3;
        if (gameObject.tag == "KEYDOOR4") requiredKey = KeyHolder.KEY4;

    }

}
