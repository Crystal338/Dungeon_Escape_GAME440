using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Door1 : MonoBehaviour
{
    //public bool slide_green_door = false;
    public bool slide_red_door = false;
    //public bool slide_blue_door = false;
    public Transform wall;
    public float descent = 1f;
    private float red_door = 0f;
    //private float blue_door = 0f;
    //private float green_door = 0f;
    //private float go = 0f;
    private void OnTriggerEnter(Collider other)
    {
        if (Inventory.has_red_stone == true)
        {
            red_door = red_door + 1;
            Destroy(this.gameObject, 8);
            slide_red_door = true;

        }

    }
    private void Update()
    {
        if (red_door == 1)
        {
            slide_red_door = true;
            {
                wall.Translate(Vector3.down * descent * Time.deltaTime);
            }
        }
    }
}
