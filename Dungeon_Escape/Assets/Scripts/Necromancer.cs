using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Necromancer : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Necromancer")
        {
            Application.Quit();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
