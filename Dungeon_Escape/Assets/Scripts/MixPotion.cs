using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixPotion : MonoBehaviour
{
    private bool PotionBlue;
    private bool PotionRed;
    public GameObject PotionPurple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PotionBlue && PotionRed)
        {
            PotionPurple.SetActive(true);
            PotionRed = false;
            PotionBlue = false;
        } 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PotionRed"))
        {
            Destroy(collision.collider.gameObject);
            PotionRed = true;
        }
        if (collision.collider.CompareTag("PotionBlue"))
        {
            Destroy(collision.collider.gameObject);
            PotionBlue = true;
        }
    }
}
