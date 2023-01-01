using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirstPickUP : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Client")){
            ThirstSlider.thirst += 30f;
            Destroy(gameObject);
        }
    }
}
