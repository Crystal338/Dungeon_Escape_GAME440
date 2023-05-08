using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorAndKey1 : MonoBehaviour
{
    public XRGrabInteractable key1;
    public GameObject door1;
    

    private bool hasKey1 = false;
    

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key1.gameObject)
        {
            hasKey1 = true;
            Destroy(door1.gameObject);
            
        }
    }

    public void TryUnlockDoor()
    {
        if (hasKey1 && door1 != null)
        {
            door1.SetActive(false);
        }
    }
}
