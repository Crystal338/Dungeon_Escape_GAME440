using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorAndKey2 : MonoBehaviour
{
    public XRGrabInteractable PotionPurple;
    public GameObject door2;
    

    private bool hasPotionPurple = false;
    

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PotionPurple.gameObject)
        {
            hasPotionPurple = true;
            Destroy(door2.gameObject);
            
        }
    }

    public void TryUnlockDoor()
    {
        if (hasPotionPurple && door2 != null)
        {
            door2.SetActive(false);
        }
    }
}
