using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PotionText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI potionText;

    private void OnTriggerEnter(Collider other)
    {
        potionText.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        potionText.enabled = false;
    }
}
