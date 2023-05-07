using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public Text messageText;

    private void OnCollisionEnter(Collision collision)
    {
        messageText.text = "Collision detected between " + gameObject.name + " and " + collision.gameObject.name;
    }
}

