using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Pickup3 : MonoBehaviour
{
    public bool blue;
    private void OnTriggerEnter(Collider other)
    {
        blue = false;

        if (blue == false)
        {
            Inventory.has_blue_stone = true;
        }

        Destroy(this.gameObject);
    }


}
