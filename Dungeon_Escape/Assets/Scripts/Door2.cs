using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Door2 : MonoBehaviour
{
    public bool slide_green_door = false;
    //public bool slide_red_door = false;
    //public bool slide_blue_door = false;
    public Transform Gate;
    public float descent = 1f;
    //private float red_door = 0f;
    //private float blue_door = 0f;
    private float green_door = 0f;
    //private float go = 0f;
    private void OnTriggerEnter(Collider other)
    {

        if (Inventory.has_green_stone == true)
        {
            green_door = green_door + 7;
            Destroy(this.gameObject, 8);
            slide_green_door = true;
        }
    }
    private void Update()
    {

        if (green_door == 7)
        {
            slide_green_door = true;
            {
                Gate.Translate(Vector3.down * descent * Time.deltaTime);
            }
        }
    }
}
