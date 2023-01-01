using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Client")){
            HungerSlider.hunger += 30f;
            Destroy(gameObject);
        }
    }
}
