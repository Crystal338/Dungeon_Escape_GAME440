using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EscapeText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI escapeText;

    private void OnTriggerEnter(Collider other)
    {
        escapeText.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        escapeText.enabled = false;
    }
}
