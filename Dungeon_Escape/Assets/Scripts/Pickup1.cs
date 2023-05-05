using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Pickup1: MonoBehaviour
{
    public bool red;
    private void OnTriggerEnter(Collider other)
    {
        red = false;

        if(red == false)
        {
            Inventory.has_red_stone = true;
        }

        Destroy(this.gameObject);
    }


}
