using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorAndKey : MonoBehaviour
{
    public XRGrabInteractable key;
    public GameObject door;
    

    private bool hasKey = false;
    

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key.gameObject)
        {
            hasKey = true;
            Destroy(key.gameObject);
            
        }
    }

    public void TryUnlockDoor()
    {
        if (hasKey && door != null)
        {
            door.SetActive(false);
        }
    }
}
