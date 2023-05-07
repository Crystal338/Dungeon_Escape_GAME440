using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Pickup2 : MonoBehaviour
{
    public bool green;
    private void OnTriggerEnter(Collider other)
    {
        green = false;

        if (green == false)
        {
            Inventory.has_green_stone = true;
        }

        Destroy(this.gameObject);
    }


}
