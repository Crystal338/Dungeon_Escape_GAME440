using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Door3 : MonoBehaviour
{
   //public bool slide_green_door = false;
    //public bool slide_red_door = false;
    public bool slide_blue_door = false;
    public Transform wall;
    public float descent = 1f;
    //private float red_door = 0f;
    private float blue_door = 0f;
    //private float green_door = 0f;
    //private float go = 0f;
    private void OnTriggerEnter(Collider other)
    {

        if (Inventory.has_blue_stone == true)
        {
            blue_door = blue_door + 5;
            Destroy(this.gameObject, 8);
            slide_blue_door = true;
        }

    }
    private void Update()
    {


        if (blue_door == 5)
        {
            slide_blue_door = true;
            {
                wall.Translate(Vector3.down * descent * Time.deltaTime);
            }
        }

    }
}
